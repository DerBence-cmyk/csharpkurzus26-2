using System;
using System.Collections.Generic;
using System.Text;

using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;

namespace GPMIDIConvert.Core.Domain.MIDI_Conversion;

public sealed record MIDIScore(
    int ticksperquarternote,
    IReadOnlyList<MIDITrack> Tracks
);

public sealed record MIDITrack(
    int TrackID,
    string Name,
    IReadOnlyList<MIDIEvent> Events
);

public abstract record MIDIEvent(long absoluteTick)
{
    public abstract MidiEvent RecordToDryWetEventConvert();

    protected static SevenBitNumber ConvertTo7Bit(int value)
    {
        return (SevenBitNumber)(byte)Math.Clamp(value, 0, 127);
    }
    protected static FourBitNumber ConvertTo4Bit(int value)
    {
        return (FourBitNumber)(byte)Math.Clamp(value, 0, 15);
    }

}

public abstract record ChannelMIDIEvent(
    long AbsoluteTick,
    int Channel
) : MIDIEvent(AbsoluteTick);

public sealed record NoteOnMIDIEvent(
    long AbsoluteTick,
    int Channel,
    int Pitch,
    int Velocity
) : ChannelMIDIEvent(AbsoluteTick, Channel)
{
    public override MidiEvent RecordToDryWetEventConvert()
    {
        return new NoteOnEvent(ConvertTo7Bit(Pitch), ConvertTo7Bit(Velocity))
        {
            Channel = ConvertTo4Bit(Channel)
        };
    }
}

public sealed record NoteOffMIDIEvent(
    long AbsoluteTick,
    int Channel,
    int Pitch,
    int Velocity = 0
) : ChannelMIDIEvent(AbsoluteTick, Channel)
{
    public override MidiEvent RecordToDryWetEventConvert()
    {
        return new NoteOffEvent(ConvertTo7Bit(Pitch), ConvertTo7Bit(Velocity))
        {
            Channel = ConvertTo4Bit(Channel)
        };
    }
}

public sealed record PitchBendMIDIEvent(
    long AbsoluteTick,
    int Channel,
    int Value = 8192
) : ChannelMIDIEvent(AbsoluteTick, Channel)
{
    public override MidiEvent RecordToDryWetEventConvert()
    {
        return new PitchBendEvent((ushort)Math.Clamp(Value, 0, 16383))
        {
            Channel = ConvertTo4Bit(Channel)
        };
    }
}

public sealed record TrackNameMetaEvent(
    long AbsoluteTick,
    string Name
) : MIDIEvent(AbsoluteTick)
{
    public override MidiEvent RecordToDryWetEventConvert()
    {
        return new SequenceTrackNameEvent(Name);
    }
}


public sealed record TempoMetaEvent(
    long AbsoluteTick,
    int MicrosecondsPerQuarterNote
) : MIDIEvent(AbsoluteTick)
{
    public override MidiEvent RecordToDryWetEventConvert()
    {
        return new SetTempoEvent(MicrosecondsPerQuarterNote);
    }
}