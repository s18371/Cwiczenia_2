using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]
[XmlTypeAttribute(typeName: "student")]
public class Student
{
    //internal Studies stu_stu;

    //internal Studies stu_stu;

    //[JsonPropertyName("FirstName")]
    [XmlElement(ElementName = "fname")]
    [JsonPropertyName("fname")]
    public string Imie { get; set; }
    [JsonPropertyName("lname")]
    [XmlElement(ElementName = "lname")]
    //[JsonPropertyName("lname")]
    public string Nazwisko { get; set; }
    [JsonPropertyName("email")]
    [XmlElement(ElementName = "email")]
    //[JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("student_indexNumber")]
    [XmlAttribute(AttributeName = "student_indexNumber")]
    //[JsonPropertyName("LastName")]
    public int Eska { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    //public string Kireunek { get; set; }
    //[XmlAttribute(AttributeName = "Inna Nazwa")]
    //[JsonPropertyName("LastName")]
    [JsonPropertyName("birthday")]
    [XmlElement(ElementName = "birthday")]
    //[JsonPropertyName("LastName")]
    public string DataUr { get; set; }
    [JsonPropertyName("mothersName")]
    [XmlElement(ElementName = "mothersName")]
    //[JsonPropertyName("LastName")]
    public string ImieM { get; set; }
    [JsonPropertyName("fathersName")]
    [XmlElement(ElementName = "fathersName")]
    //[JsonPropertyName("LastName")]
    public string ImieO { get; set; }
    //[XmlElement(ElementName = "studies")]
    //[XmlElement(ElementName = "name")]
    //public string Kireunek { get; set; }
    //[XmlElement(ElementName = "mode")]
    //public string TrybSt { get; set; }
    //[XmlType(typeName: "studies")]
    [JsonPropertyName("studies")]
    [XmlElement(ElementName = "studies")]
    public Studies Studia{get; set;}


    public bool equals(Student studt) {
            return Imie == studt.Imie && Nazwisko == studt.Nazwisko 
               && Eska== studt.Eska;
        }



}
