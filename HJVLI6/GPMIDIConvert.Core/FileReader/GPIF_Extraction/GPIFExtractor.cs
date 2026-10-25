using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

using GPMIDIConvert.Core.FileReader.Interfaces;

namespace GPMIDIConvert.Core.FileReader.GPIF_Extraction;

public class GPIFExtractor : IGPIFExtractor
{
    public async Task<string> ExtractGpifXmlAsync(string filePath)
    {
        using ZipArchive archive = ZipFile.OpenRead(filePath);
        ZipArchiveEntry? gpifEntry = archive.GetEntry("Content/score.gpif");

        if (gpifEntry is null)
            throw new FileNotFoundException("No .gpif file was found.");

        using StreamReader reader = new StreamReader(gpifEntry.Open());
        return await reader.ReadToEndAsync();
    }
}
