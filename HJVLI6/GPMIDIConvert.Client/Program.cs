using System;
using System.IO;
using System.Text.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using GPMIDIConvert.Core.Domain.Storage;
using GPMIDIConvert.Core.Domain.Storage.Interfaces;
using GPMIDIConvert.Core.FileReader.GPIF_Extraction;
using GPMIDIConvert.Core.Serialization;

string gpFilePath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\TestFiles\Welcome to Guitar Tab Player.gp");

var extractor = new GPIFExtractor();
var deserializer = new GPIFDeserializer();
var calculator = new GPToMIDITimeCalculator();
var noteScraper = new GPNoteScraper();

var builder = new EventCollectionBuilder(extractor, deserializer, calculator, noteScraper);
const int tpqn = 480;
GuitarProScore score = builder.BuildScoreFromFile(gpFilePath, tpqn);

