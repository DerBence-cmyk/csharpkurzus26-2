using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Domain.MIDI_Conversion;

namespace GPMIDIConvert.Core.Domain.MIDI_Writing.Interfaces;

public interface IMIDIFileBuilder
{
    void WriteToFile(MIDIScore score, string outputPath, bool overwrite = true);
}
