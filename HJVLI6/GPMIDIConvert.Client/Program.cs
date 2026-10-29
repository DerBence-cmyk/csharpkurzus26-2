using System;
using System.IO;
using System.Text.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using GPMIDIConvert.Core.Domain.MIDI_Conversion;
using GPMIDIConvert.Core.Domain.MIDI_Conversion.Templates.Library_Templates.Shreddage;
using GPMIDIConvert.Core.Domain.MIDI_Writing;
using GPMIDIConvert.Core.Domain.Storage;
using GPMIDIConvert.Core.Domain.Storage.Interfaces;
using GPMIDIConvert.Core.FileReader.GPIF_Extraction;
using GPMIDIConvert.Core.Serialization;

string gpFilePath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\TestFiles\Welcome to Guitar Tab Player.gp");
string midiOutputPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\TestFiles\Welcome to Guitar Tab Player.mid");

var extractor = new GPIFExtractor();
var deserializer = new GPIFDeserializer();
var calculator = new GPToMIDITimeCalculator();
var noteScraper = new GPNoteScraper();

var builder = new EventCollectionBuilder(extractor, deserializer, calculator, noteScraper);
const int tpqn = 480;
GuitarProScore score = builder.BuildScoreFromFile(gpFilePath, tpqn);



var profile = new ShreddageThreeJupiter();
MIDIScore midiScore = profile.TranslateScore(score, tpqn);


var MIDIBuilder = new MIDIFileBuilder();
MIDIBuilder.WriteToFile(midiScore, midiOutputPath, overwrite: true);

Console.WriteLine("Kesz.");