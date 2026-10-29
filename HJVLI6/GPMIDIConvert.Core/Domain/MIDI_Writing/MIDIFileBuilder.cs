using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.MIDI_Conversion;
using GPMIDIConvert.Core.Domain.MIDI_Writing.Interfaces;
using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;

namespace GPMIDIConvert.Core.Domain.MIDI_Writing;

public class MIDIFileBuilder : IMIDIFileBuilder
{
    public void WriteToFile(MIDIScore score, string outputPath, bool overwrite = true)
    {
        var MIDIFile = new MidiFile
        {
            TimeDivision = new TicksPerQuarterNoteTimeDivision((short)score.ticksperquarternote)
        };

        foreach (var track in score.Tracks)
        {
            TrackChunk trackChunk = BuildTrackChunk(track);
            MIDIFile.Chunks.Add(trackChunk);
        }


        string? directory = Path.GetDirectoryName(outputPath);
        Directory.CreateDirectory(directory);

        MIDIFile.Write(outputPath, overwriteFile: overwrite, format: MidiFileFormat.MultiTrack);
    }

    private static TrackChunk BuildTrackChunk(MIDITrack track)
    {
        var trackChunk = new TrackChunk();
        long previousTick = 0;

        foreach (var e in track.Events)
        {
            long deltaTime = Math.Max(0, e.absoluteTick - previousTick);
            previousTick = e.absoluteTick;

            MidiEvent dryWetEvent = e.RecordToDryWetEventConvert();
            dryWetEvent.DeltaTime = deltaTime;

            trackChunk.Events.Add(dryWetEvent);
        }

        return trackChunk;
    }
}
