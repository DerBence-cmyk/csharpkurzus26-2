using System;
using System.Collections.Generic;
using System.Text;

namespace GPMIDIConvert.Core.FileReader.Interfaces;

public interface IGPIFExtractor
{
    Task<string> ExtractGpifXmlAsync(string filePath);

}
