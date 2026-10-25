using System;
using System.IO;
using System.Xml.Serialization;

using GPMIDIConvert.Core.FileReader.GPIF_Extraction;
using GPMIDIConvert.Core.Serialization;

string gpFilePath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\TestFiles\Welcome to Guitar Tab Player.gp");

var extractor = new GPIFExtractor();
string xmlContent = await extractor.ExtractGpifXmlAsync(gpFilePath);

Console.WriteLine($"XML length: {xmlContent.Length} characters");

var serializer = new XmlSerializer(typeof(GPIF));
using var stringReader = new StringReader(xmlContent);
var gpif = (GPIF?)serializer.Deserialize(stringReader);

if (gpif is not null)
{
    Console.WriteLine($"GP Version: {gpif.GPVersion}");
    Console.WriteLine($"Song Title: {gpif.Score?.Title}");
    Console.WriteLine($"Tracks Count: {gpif.Tracks?.Track?.Length ?? 0}");
    Console.WriteLine($"MasterBars Count: {gpif.MasterBars?.Length ?? 0}");
    Console.WriteLine($"Notes Count: {gpif.Notes?.Length ?? 0}");
}