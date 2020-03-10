using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]
public class Student
{
    [JsonPropertyName("FirstName")]
    [XmlElement(ElementName = "FirstName")]
    public string Imie { get; set; }
    [XmlAttribute(AttributeName = "LastName")]
    [JsonPropertyName("LastName")]
    public string Nazwisko { get; set; }
    [XmlAttribute(AttributeName = "Email")]
    [JsonPropertyName("Email")]
    public string Email { get; set; }
    //[XmlAttribute(AttributeName ="Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public int Eska { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string Kireunek { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string TrybSt { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string DataUr { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string ImieM { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string ImieO { get; set; }
    

}
