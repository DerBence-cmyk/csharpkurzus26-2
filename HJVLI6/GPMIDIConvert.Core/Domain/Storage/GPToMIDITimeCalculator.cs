using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.Storage.Interfaces;
using GPMIDIConvert.Core.Serialization;

namespace GPMIDIConvert.Core.Domain.Storage;

public class GPToMIDITimeCalculator : ITimingCalculator
{
    private static readonly Dictionary<string, double> NoteFractionTypes = new()
    {
        ["Whole"] = 4.0,
        ["Half"] = 2.0,
        ["Quarter"] = 1.0,
        ["Eighth"] = 0.5,
        ["16th"] = 0.25,
        ["32nd"] = 0.125,
        ["64th"] = 0.0625
    };
    public long CalculateMeasureTicks(string timeSignature, int ticksperquarternote)
    {
        var parts = timeSignature.Split('/');
        double numerator = double.Parse(parts[0]);
        double denominator = double.Parse(parts[1]);

        return (long)((numerator / (denominator / 4.0)) * ticksperquarternote);
    }

    public long CalculateRhythmTicks(GPIFRhythm rhythm, int ticksperquarternote)
    {
        double currentFraction = 1.0;

        if (rhythm != null && rhythm.NoteValue != null)
        {
            if (NoteFractionTypes.TryGetValue(rhythm.NoteValue, out double foundFraction))
            {
                currentFraction = foundFraction;
            }
        }

        double duration = currentFraction * ticksperquarternote;

        if (rhythm?.AugmentationDot != null)
        {
            double multiplier = 1.0 - Math.Pow(0.5, rhythm.AugmentationDot.count);
            duration += duration * multiplier;
        }

        if (rhythm?.PrimaryTuplet != null && rhythm.PrimaryTuplet.num > 0)
        {
            duration = (duration * rhythm.PrimaryTuplet.den) / rhythm.PrimaryTuplet.num;
        }

        return (long)duration;
    }
}
