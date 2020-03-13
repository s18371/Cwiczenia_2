using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Cwiczenia_2.Models
{
    
    public class activeStudies
    {
        [XmlElement(ElementName = "studies_name")]
        public List<string> kierunki{get;set; }
    }
}
