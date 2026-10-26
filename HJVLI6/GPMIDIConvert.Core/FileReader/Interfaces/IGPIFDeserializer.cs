using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Serialization;

namespace GPMIDIConvert.Core.FileReader.Interfaces;

public interface IGPIFDeserializer
{
    GPIF Deserialize(string xmlContent);
}
