using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Serialization;

namespace GPMIDIConvert.Core.Domain.Storage.Interfaces;

public interface ITimingCalculator
{
    long CalculateMeasureTicks(string timeSignature, int ticksperquarternote);
    long CalculateRhythmTicks(GPIFRhythm rhythm, int ticksperquarternote);
}
