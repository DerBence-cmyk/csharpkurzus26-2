using System;
using System.Collections.Generic;
using System.Text;

namespace GPMIDIConvert.Core.Domain.Storage.Interfaces;

public interface IEventCollectionBuilder
{
    GuitarProScore BuildScoreFromFile(string path, int ticksperquarternote);
}
