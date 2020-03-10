using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]
public class Student
{
    [JsonPropertyName("LastName")]
    [XmlElement(ElementName = "InneNazwa")]
    public string Imie { get; set; }
    [XmlAttribute(AttributeName = "InnaNazwa")]
    [JsonPropertyName("LastName")]
    public string Nazwisko { get; set; }
    [XmlAttribute(AttributeName = "InnaNazwa")]
    [JsonPropertyName("LastName")]
    public string Email { get; set; }
    [XmlAttribute(AttributeName ="Inna Nazwa")]
    [JsonPropertyName("LastName")]
    public int Eska { get; set; }
    [XmlAttribute(AttributeName = "Inna Nazwa")]
    [JsonPropertyName("LastName")]
    public string Kireunek { get; set; }
    [XmlAttribute(AttributeName = "Inna Nazwa")]
    [JsonPropertyName("LastName")]
    public string TrybSt { get; set; }
    [XmlAttribute(AttributeName = "Inna Nazwa")]
    [JsonPropertyName("LastName")]
    public string DataUr { get; set; }
    [XmlAttribute(AttributeName = "Inna Nazwa")]
    [JsonPropertyName("LastName")]
    public string ImieM { get; set; }
    [XmlAttribute(AttributeName = "Inna Nazwa")]
    [JsonPropertyName("LastName")]
    public string ImieO { get; set; }
    

}
