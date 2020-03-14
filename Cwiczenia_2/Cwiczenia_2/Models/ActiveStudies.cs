using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Cwiczenia_2.Models
{
    
    public class activeStudies
    {
        [JsonPropertyName("studies_name")]
        [XmlAttribute(AttributeName = "name")]
        public string name { get; set; }
        public string mode { get; set; }
        [XmlAttribute(AttributeName = "numberOfStudents")]
        public string numberOfStud { get; set; }
        
    }
}
