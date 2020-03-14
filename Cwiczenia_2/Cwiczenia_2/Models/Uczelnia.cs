using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Cwiczenia_2.Models
{
    public class Uczelnia
    {
        [JsonPropertyName("createdAt")]
        [XmlAttribute(AttributeName = "createdAt")]
        public string data { get; set; }
        [JsonPropertyName("author")]
        [XmlAttribute(AttributeName = "author")]
        public string author { get; set; }
        //[XmlElement(ElementName = "studenci")]
        public List<Student> studenci { get; set; }
        [JsonPropertyName("activeStudies")]
        [XmlElement(ElementName = "activeStudies")]
        public List<activeStudies> kierunki { get; set; }
    }
}
