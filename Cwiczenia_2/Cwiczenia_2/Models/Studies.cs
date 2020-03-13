using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]
[XmlTypeAttribute(typeName: "studies")]
//[XmlTypeAttribute(typeName: "studies")]
public class Studies
{
	[JsonPropertyName("name")]
	[XmlElement(ElementName = "name")]
	public string Kierunek { get; set; }
	[JsonPropertyName("mode")]
	[XmlElement(ElementName = "mode")]
	public string TrybSt { get; set; }

}
