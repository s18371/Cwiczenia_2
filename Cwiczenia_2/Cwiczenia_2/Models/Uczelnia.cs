using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cwiczenia_2.Models
{
    public class Uczelnia
    {
        [XmlAttribute(AttributeName = "createdAt")]
        public string data { get; set; }
        [XmlAttribute(AttributeName = "author")]
        public string author { get; set; }
        [XmlElement(ElementName = "studenci")]
        public List<Student> ListaS { get; set; }
        [XmlElement(ElementName = "activeStudies")]
        public activeStudies ActiveS { get; set; }
    }
}
