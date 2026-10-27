using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.Storage.Interfaces;
using GPMIDIConvert.Core.FileReader.GPIF_Extraction;
using GPMIDIConvert.Core.FileReader.Interfaces;
using GPMIDIConvert.Core.Serialization;

namespace GPMIDIConvert.Core.Domain.Storage;

public class EventCollectionBuilder : IEventCollectionBuilder
{
    private readonly IGPIFExtractor _extractor;
    private readonly GPIFDeserializer _deserializer;
    private readonly ITimingCalculator _calculator;

    private readonly IGPNoteScraper _noteScraper;

    public EventCollectionBuilder(IGPIFExtractor extractor, GPIFDeserializer deserializer, ITimingCalculator calculator, IGPNoteScraper noteScraper)
    {
        _extractor = extractor;
        _deserializer = deserializer;
        _calculator = calculator;
        _noteScraper = noteScraper;
    }

    public GuitarProScore BuildScoreFromFile(string path, int ticksperquarternote)
    {
        string xmlContent = Task.Run(() => _extractor.ExtractGpifXmlAsync(path)).GetAwaiter().GetResult();
        GPIF gpif = _deserializer.Deserialize(xmlContent);

        return Build(gpif, ticksperquarternote);
    }

    private GuitarProScore Build(GPIF gpif, int ticksperquarternote)
    {
        var bars = gpif.Bars.ToDictionary(bar => bar.id);
        var voices = gpif.Voices.ToDictionary(voice => voice.id);
        var beats = gpif.Beats.ToDictionary(beat => beat.id);
        var notes = gpif.Notes.ToDictionary(note => note.id);
        var rhythms = gpif.Rhythms.ToDictionary(rhythm => rhythm.id);

        var guitarProTracks = new List<GuitarProTrack>();

        if (gpif.Tracks?.Track != null)
        {
            for (int trackindex = 0; trackindex < gpif.Tracks.Track.Length; trackindex++)
            {
                var rawTrack = gpif.Tracks.Track[trackindex];

                int[] trackTuningPitches = _noteScraper.ExtractTrackTuning(rawTrack);

                List<GuitarProNote> notesList = ExtractNotesForTrack(
                    gpif,
                    trackindex,
                    trackTuningPitches,
                    ticksperquarternote,
                    bars,
                    voices,
                    beats,
                    notes,
                    rhythms);

                string trackName;

                if (rawTrack.Name != null)
                {
                    trackName = rawTrack.Name;
                }
                else
                {
                    trackName = $"Track {rawTrack.id}";
                }

                guitarProTracks.Add(new GuitarProTrack(
                    TrackID: rawTrack.id,
                    Name: trackName,
                    Notes: notesList));
            }
        }

        return new GuitarProScore(
            Title: gpif.Score?.Title,
            Artist: gpif.Score?.Artist,
            Tracks: guitarProTracks);
    }

    private List<GuitarProNote> ExtractNotesForTrack(
        GPIF gpif,
        int trackindex,
        int[] trackTuningPitches,
        int ticksperquarternote,
        IReadOnlyDictionary<int, GPIFBar> bars,
        IReadOnlyDictionary<int, GPIFVoice> voices,
        IReadOnlyDictionary<int, GPIFBeat> beats,
        IReadOnlyDictionary<int, GPIFNote> notes,
        IReadOnlyDictionary<int, GPIFRhythm> rhythms)
    {
        var resultnotes = new List<GuitarProNote>();
        long absolutetick = 0;

        if (gpif.MasterBars == null)
        {
            return resultnotes;
        }

        foreach (var masterbar in gpif.MasterBars)
        {
            long currentMeasureStartTick = absolutetick;
            string[] barIDs = masterbar.Bars.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int barID = int.Parse(barIDs[trackindex]);

            var bar = bars[barID];
            string[] voiceIDs = bar.Voices.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (voiceIDs.Length > 0 && voiceIDs[0] != "-1")
            {
                var voice = voices[int.Parse(voiceIDs[0])];
                string[] beatIDs = voice.Beats?.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                long currentBeatTick = currentMeasureStartTick;

                if (beatIDs != null)
                {
                    foreach (var beatIDstring in beatIDs)
                    {
                        var beat = beats[int.Parse(beatIDstring)];
                        var rhythm = rhythms[beat.Rhythm.@ref];

                        long beatDurationTicks = _calculator.CalculateRhythmTicks(rhythm, ticksperquarternote);

                        if (!string.IsNullOrEmpty(beat.Notes))
                        {
                            string[] noteIDs = beat.Notes.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            foreach (var noteIDstring in noteIDs)
                            {
                                var note = notes[int.Parse(noteIDstring)];

                                GuitarProNote scrapedNote = _noteScraper.NoteScraper(
                                    note: note,
                                    beat: beat,
                                    trackTuningPitches: trackTuningPitches,
                                    startTick: currentBeatTick,
                                    durationTicks: beatDurationTicks);

                                resultnotes.Add(scrapedNote);
                            }
                        }

                        currentBeatTick += beatDurationTicks;
                    }
                }
            }

            absolutetick += _calculator.CalculateMeasureTicks(masterbar.Time, ticksperquarternote);
        }

        return resultnotes;
    }
}
