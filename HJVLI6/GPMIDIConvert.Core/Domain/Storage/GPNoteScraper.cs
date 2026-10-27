using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.Storage.Interfaces;
using GPMIDIConvert.Core.Serialization;

namespace GPMIDIConvert.Core.Domain.Storage;

public class GPNoteScraper : IGPNoteScraper
{
    private static readonly Dictionary<string, int> velocityDictionary = new()
    {
        ["PPP"] = 30,
        ["PP"] = 45,
        ["P"] = 60,
        ["MP"] = 75,
        ["MF"] = 90,
        ["F"] = 105,
        ["FF"] = 115,
        ["FFF"] = 127
    };
    public int[] ExtractTrackTuning(GPIFTracksTrack track)
    {

        var tuningProperty = track.Staves.Staff[0].Properties.Property;

        foreach (var prop in tuningProperty)
        {
            if (prop.name == "Tuning")
            {
                string[] pitchStrings = prop.Pitches.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] pitches = new int[pitchStrings.Length];

                for (int i = 0; i < pitchStrings.Length; i++)
                {
                    pitches[i] = int.Parse(pitchStrings[i]);
                }
                return pitches;
            }
        }

        throw new InvalidOperationException($"Tuning missing for track ID {track.id}.");
    }

    private static int CalculateVelocity(GPIFNote note, GPIFBeat beat)
    {
        if (note.VelocitySpecified)
        {
            return note.Velocity;
        }

        if (velocityDictionary.TryGetValue(beat.Dynamic, out int dynamicVelocityValue))
        {
            return dynamicVelocityValue;
        }

        return 95;
    }

    private static int ExtractBeatXPropertyInt(GPIFBeat beat, uint targetID, int defaultVal)
    {
        if (beat.XProperties != null)
        {
            foreach (var xproperty in beat.XProperties)
            {
                if (xproperty.id == targetID && xproperty.IntSpecified)
                {
                    return xproperty.Int;
                }
            }
        }
        return defaultVal;
    }

    public GuitarProNote NoteScraper(GPIFNote note, GPIFBeat beat, int[] trackTuningPitches, long startTick, long durationTicks)
    {
        int stringIndex = 0;
        int fret = 0;
        int explicitMidiPitch = -1;
        var articulations = new List<NoteArticulation>();

        if (note.Properties != null)
        {
            foreach (var prop in note.Properties)
            {
                switch (prop.name)
                {
                    case "String" when prop.StringSpecified:
                        stringIndex = prop.String;
                        break;
                    case "Fret" when prop.FretSpecified:
                        fret = prop.Fret;
                        break;
                    case "Midi" when prop.NumberSpecified:
                        explicitMidiPitch = prop.Number;
                        break;
                    case "PalmMuted" when prop.Enable != null:
                        articulations.Add(new PalmMuteArticulation());
                        break;
                    case "Muted" when prop.Enable != null:
                        articulations.Add(new DeadNoteArticulation());
                        break;
                    case "Tapped" when prop.Enable != null:
                        articulations.Add(new TapArticulation());
                        break;
                    case "Slide" when prop.FlagsSpecified:
                        articulations.Add(new SlideArticulation(prop.Flags));
                        break;
                }
            }

            if (ExtractHopo(note.Properties, out var hopo))
            {
                articulations.Add(hopo);
            }

            if (ExtractHarmonic(note.Properties, out var harmonic))
            {
                articulations.Add(harmonic);
            }

            if (ExtractBend(note.Properties, out var bend))
            {
                articulations.Add(bend);
            }
        }

        if (note.LetRing != null)
        {
            articulations.Add(new LetRingArticulation());
        }

        if (!string.IsNullOrEmpty(note.Vibrato))
        {
            articulations.Add(new VibratoArticulation(note.Vibrato, isTremolo: false));
        }

        if (!string.IsNullOrEmpty(note.AntiAccent))
        {
            articulations.Add(new GhostNoteArticulation());
        }

        if (note.AccentSpecified && note.Accent > 0)
        {
            articulations.Add(new AccentArticulation(note.Accent));
        }

        if (!string.IsNullOrEmpty(note.Ornament))
        {
            articulations.Add(new OrnamentArticulation(note.Ornament));
        }

        if (note.Tie != null && (note.Tie.origin || note.Tie.destination))
        {
            articulations.Add(new TieArticulation(note.Tie.origin, note.Tie.destination));
        }

        if (note.TrillSpecified)
        {
            int trillspeed = 120;
            if (note.XProperties?.XProperty != null)
            {
                foreach (var xproperty in note.XProperties.XProperty)
                {
                    if (xproperty.id == 688062467)
                    {
                        trillspeed = xproperty.Int;
                    }
                }
            }

            articulations.Add(new TrillArticulation(note.Trill, trillspeed));
        }

        if (beat.Whammy != null)
        {
            var whammy = beat.Whammy;

            articulations.Add(new WhammyArticulation(
                whammy.originValue,
                whammy.originOffset,
                whammy.middleValue,
                whammy.middleOffset1,
                whammy.middleOffset2,
                whammy.destinationValue,
                whammy.destinationOffset));
        }

        if (beat.Legato != null && (beat.Legato.origin || beat.Legato.destination))
        {
            articulations.Add(new LegatoArticulation(beat.Legato.origin, beat.Legato.destination));
        }

        if (!string.IsNullOrEmpty(beat.GraceNotes))
        {
            articulations.Add(new GraceNoteArticulation(beat.GraceNotes));
        }

        if (!string.IsNullOrEmpty(beat.Tremolo))
        {
            articulations.Add(new TremoloPickingArticulation(beat.Tremolo));
        }

        if (!string.IsNullOrEmpty(beat.Golpe))
        {
            articulations.Add(new GolpeArticulation(beat.Golpe));
        }

        if (beat.DeadSlapped != null)
        {
            articulations.Add(new DeadSlapArticulation());
        }

        if (!string.IsNullOrEmpty(beat.Arpeggio))
        {
            int arpTicks = ExtractBeatXPropertyInt(beat, 687931393, defaultVal: 120);

            articulations.Add(new ArpeggioArticulation(beat.Arpeggio, arpTicks));
        }

        foreach (var beatProp in beat.Properties)
        {
            switch (beatProp.name)
            {
                case "PickStroke" when !string.IsNullOrEmpty(beatProp.Direction):
                    articulations.Add(new PickStrokeArticulation(beatProp.Direction));
                    break;
                case "VibratoWTremBar" when !string.IsNullOrEmpty(beatProp.Strength):
                    articulations.Add(new VibratoArticulation(beatProp.Strength, isTremolo: true));
                    break;
                case "Slapped" when beatProp.Enable != null:
                    articulations.Add(new SlapArticulation());
                    break;
                case "Popped" when beatProp.Enable != null:
                    articulations.Add(new PopArticulation());
                    break;
                case "Brush" when !string.IsNullOrEmpty(beatProp.Direction):
                    int brushTicks = ExtractBeatXPropertyInt(beat, 687935489, defaultVal: 120);
                    articulations.Add(new BrushArticulation(beatProp.Direction, brushTicks));
                    break;
            }
        }

        int midiPitch = CalculateMidiPitch(explicitMidiPitch, trackTuningPitches, stringIndex, fret);
        int velocity = CalculateVelocity(note, beat);

        return new GuitarProNote(
            NoteID: note.id,
            MidiPitch: midiPitch,
            Velocity: velocity,
            StartTick: startTick,
            DurationTicks: durationTicks,
            StringNumber: stringIndex + 1,
            Fret: fret,
            Articulations: articulations
        );
    }

    private static int CalculateMidiPitch(int explicitMIDIPitch, int[] trackTuningPitches, int stringIndex, int fret)
    {
        if (explicitMIDIPitch >= 0)
        {
            return explicitMIDIPitch;
        }

        return trackTuningPitches[stringIndex] + fret;
    }

    private static bool ExtractHopo(GPIFNoteProperty[] properties, out HopoArticulation hopo)
    {
        bool origin = false;
        bool dest = false;
        bool found = false;

        foreach (var prop in properties)
        {
            if (prop.name == "HopoOrigin" && prop.Enable != null)
            {
                origin = true;
                found = true;
            }

            if (prop.name == "HopoDestination" && prop.Enable != null)
            {
                dest = true;
                found = true;
            }
        }

        if (found)
        {
            hopo = new HopoArticulation(origin, dest);
        }
        else
        {
            hopo = null;
        }

        return found;
    }

    private static bool ExtractHarmonic(GPIFNoteProperty[] properties, out HarmonicArticulation harmonic)
    {
        bool isHarmonic = false;
        string type = "Natural";
        decimal fret = 0;

        foreach (var prop in properties)
        {
            if (prop.name == "Harmonic" && prop.Enable != null)
            {
                isHarmonic = true;
            }

            if (prop.name == "HarmonicType" && !string.IsNullOrEmpty(prop.HType))
            {
                type = prop.HType;
            }

            if (prop.name == "HarmonicFret" && prop.HFretSpecified)
            {
                fret = prop.HFret;
            }
        }

        if (isHarmonic)
        {
            harmonic = new HarmonicArticulation(type, fret);
        }
        else
        {
            harmonic = null;
        }

        return isHarmonic;
    }

    private static bool ExtractBend(GPIFNoteProperty[] properties, out BendArticulation bend)
    {
        bool isBend = false;
        decimal value= 0;
        decimal offset = 0;
        decimal middleValue = 0;
        decimal midOffset1 = 0;
        decimal midOffset2 = 0;
        decimal destValue = 0; 
        decimal destOffset = 0;

        foreach (var prop in properties)
        {
            switch (prop.name)
            {
                case "Bended" when prop.Enable != null: isBend = true; break;
                case "BendOriginValue" when prop.FloatSpecified: value = prop.Float; break;
                case "BendOriginOffset" when prop.FloatSpecified: offset = prop.Float; break;
                case "BendMiddleValue" when prop.FloatSpecified: middleValue = prop.Float; break;
                case "BendMiddleOffset1" when prop.FloatSpecified: midOffset1 = prop.Float; break;
                case "BendMiddleOffset2" when prop.FloatSpecified: midOffset2 = prop.Float; break;
                case "BendDestinationValue" when prop.FloatSpecified: destValue = prop.Float; break;
                case "BendDestinationOffset" when prop.FloatSpecified: destOffset = prop.Float; break;
            }
        }

        if (isBend)
        {
            bend = new BendArticulation(value, offset, middleValue, midOffset1, midOffset2, destValue, destOffset);
        }
        else
        {
            bend = null;
        }

        return isBend;
    }
}

