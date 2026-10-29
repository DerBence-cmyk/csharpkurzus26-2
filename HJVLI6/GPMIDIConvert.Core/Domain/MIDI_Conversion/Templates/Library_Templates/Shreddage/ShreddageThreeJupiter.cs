using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

using GPMIDIConvert.Core.Domain.Storage;

using static GPMIDIConvert.Core.Domain.MIDI_Conversion.Templates.Library_Templates.Shreddage.ShreddageThreeJupiter;

namespace GPMIDIConvert.Core.Domain.MIDI_Conversion.Templates.Library_Templates.Shreddage;

public class ShreddageThreeJupiter : InstrumentProfile
{
    public override string LibraryName => "Shreddage 3 Jupiter";

    public static class KeySwitches
    {
        public const int PalmMute = 13;
    }


    void addPalmMute(GuitarProNote note, List<MIDIEvent> eventList)
    {
        if (note.Articulations.Any(a => a is PalmMuteArticulation))
        {
            long keyswitchTick = Math.Max(0, note.StartTick - 200);

            eventList.Add(new NoteOnMIDIEvent(keyswitchTick, note.StringNumber, KeySwitches.PalmMute, Velocity: 127));
            eventList.Add(new NoteOffMIDIEvent(note.StartTick, note.StringNumber, KeySwitches.PalmMute));

            eventList.Add(new NoteOnMIDIEvent(note.StartTick, note.StringNumber, note.MidiPitch, note.Velocity));
            eventList.Add(new NoteOffMIDIEvent(note.DurationTicks, note.StringNumber, note.MidiPitch));
        }
    }
}
