using System;
using System.Xml.Serialization;

[Serializable]
[XmlTypeAttribute(typeName: "studies")]
//[XmlTypeAttribute(typeName: "studies")]
public class Studies
{
	[XmlElement(ElementName = "name")]
	public string Kierunek { get; set; }
	[XmlElement(ElementName = "mode")]
	public string TrybSt { get; set; }

}
