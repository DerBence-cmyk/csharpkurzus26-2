using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace GPMIDIConvert.Core.Serialization;

public class GPIFDeserializer
{
    private static readonly XmlSerializer serializer = new(typeof(GPIF));

    public GPIF Deserialize(string xmlContent)
    {
        if (xmlContent == null)
        {
            throw new ArgumentNullException();
        }

        using var stringReader = new StringReader(xmlContent);
        using var xmlReader = XmlReader.Create(stringReader);

        object? result = serializer.Deserialize(xmlReader);

        if (result is not GPIF gpif)
        {
            throw new InvalidDataException("Deserialization returned null.");
        }

        return gpif;
    }
}
