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
        [XmlElement(ElementName = "studies_name")]
        public List<string> kierunki{get;set; }
    }
}
