using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]
public class Student
{
    //[JsonPropertyName("FirstName")]
    [XmlElement(ElementName = "fname")]
    public string Imie { get; set; }
    [XmlElement(ElementName = "lname")]
    //[JsonPropertyName("lname")]
    public string Nazwisko { get; set; }
    [XmlElement(ElementName = "email")]
    //[JsonPropertyName("email")]
    public string Email { get; set; }
    [XmlAttribute(AttributeName ="student indexNumber")]
    //[JsonPropertyName("LastName")]
    public int Eska { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string Kireunek { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    public string TrybSt { get; set; }
    [XmlElement(ElementName = "birthday")]
    //[JsonPropertyName("LastName")]
    public string DataUr { get; set; }
    [XmlElement(ElementName = "mothersName")]
    //[JsonPropertyName("LastName")]
    public string ImieM { get; set; }
    [XmlElement(ElementName = "fathersName")]
    //[JsonPropertyName("LastName")]
    public string ImieO { get; set; }
    

}
