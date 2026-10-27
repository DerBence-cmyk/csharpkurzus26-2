using System;
using System.Collections.Generic;
using System.Text;

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

public abstract record MIDIEvent(long absoluteTick);

public abstract record ChannelMIDIEvent(
    long AbsoluteTick,
    int Channel
) : MIDIEvent(AbsoluteTick);

public sealed record NoteOnMIDIEvent(
    long AbsoluteTick,
    int Channel,
    int Pitch,
    int Velocity
) : ChannelMIDIEvent(AbsoluteTick, Channel);

public sealed record NoteOffMIDIEvent(
    long AbsoluteTick,
    int Channel,
    int Pitch,
    int Velocity = 0
) : ChannelMIDIEvent(AbsoluteTick, Channel);

public sealed record PitchBendMIDIEvent(
    long AbsoluteTick,
    int Channel,
    int Value = 8192
) : ChannelMIDIEvent(AbsoluteTick, Channel);

public sealed record TrackNameMetaEvent(
    long AbsoluteTick,
    string Name
) : MIDIEvent(AbsoluteTick);

public sealed record TempoMetaEvent(
    long AbsoluteTick,
    int MicrosecondsPerQuarterNote
) : MIDIEvent(AbsoluteTick);