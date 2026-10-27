using System;
using System.Collections.Generic;
using System.Text;

using GPMIDIConvert.Core.Serialization;

namespace GPMIDIConvert.Core.Domain.Storage.Interfaces;

public interface IGPNoteScraper
{
    int[] ExtractTrackTuning(GPIFTracksTrack track);
    GuitarProNote NoteScraper(
        GPIFNote note,
        GPIFBeat beat,
        int[] trackTuningPitches,
        long startTick,
        long durationTicks);
}
