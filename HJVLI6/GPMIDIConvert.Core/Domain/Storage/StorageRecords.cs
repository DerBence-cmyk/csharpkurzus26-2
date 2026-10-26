using System;
using System.Collections.Generic;
using System.Text;

namespace GPMIDIConvert.Core.Domain.Storage;

public sealed record GuitarProScore(
    string Title,
    string Artist,
    List<GuitarProTrack> Tracks
);

public sealed record GuitarProTrack(
    int TrackID,
    string Name,
    List<GuitarProNote> Notes
);

public sealed record GuitarProNote(
    int NoteID,
    int MidiPitch,
    int Velocity,
    long StartTick,
    long DurationTicks,
    int StringNumber,
    int Fret,
    string Articulation
);
