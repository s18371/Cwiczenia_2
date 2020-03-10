using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]
public class Student
{
    [XmlElement(ElementName = "InneNazwa")]
    public string Imie { get; set; }
    [XmlAttribute(AttributeName = "InnaNazwa")]
    [JsonPropertyName("LastName")]
    public string Nazwisko { get; set; }
    [XmlAttribute(AttributeName = "InnaNazwa")]
    public string Email { get; set; }

    public string Eska { get; set; }
    public string Kireunek { get; set; }

    public string TrybSt { get; set; }

    public string DataUr { get; set; }
    public string ImieM { get; set; }
    public string ImieO { get; set; }

}
