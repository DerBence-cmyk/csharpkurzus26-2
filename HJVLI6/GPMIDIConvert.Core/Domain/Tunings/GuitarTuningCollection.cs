using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.Tunings.Interfaces;

namespace GPMIDIConvert.Core.Domain.Tunings;

public class GuitarTuningCollection : IGuitarTuningCollection
{
    private static readonly Dictionary<string, GuitarTuning> Tunings = new()
    {
        ["Shreddage 3 Jupiter"] = new("Shreddage 3 Jupiter", new[]
        {
            new GuitarString(1, 64), // E4
            new GuitarString(2, 59), // B3
            new GuitarString(3, 55), // G3
            new GuitarString(4, 50), // D3
            new GuitarString(5, 45), // A2
            new GuitarString(6, 40), // E2
            new GuitarString(7, 33)  // A1
        }),

    };

    public IEnumerable<string> GetAvailableTuningNames() => Tunings.Keys;

    public GuitarTuning GetTuning(string name)
    {
        if (Tunings.TryGetValue(name, out var tuning))
        {
            return tuning;
        }

        throw new KeyNotFoundException($"Invalid guitar tuning");
    }
}
