using System;
using System.Collections.Generic;
using System.Text;

namespace GPMIDIConvert.Core.Domain.Tunings;

public sealed record GuitarString(
    int StringIndex,
    int MidiPitch
);
public sealed record GuitarTuning(
    string Name,
    IReadOnlyList<GuitarString> Strings
);
