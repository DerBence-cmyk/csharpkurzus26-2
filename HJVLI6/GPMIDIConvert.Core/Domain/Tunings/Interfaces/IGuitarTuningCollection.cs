using System;
using System.Collections.Generic;
using System.Text;

namespace GPMIDIConvert.Core.Domain.Tunings.Interfaces;

public interface IGuitarTuningCollection
{
    GuitarTuning GetTuning(string name);
    IEnumerable<string> GetAvailableTuningNames();
}
