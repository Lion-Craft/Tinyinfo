using System;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Linq;

namespace Tinyinfo
{
	class XML
	{
		public static string CreateXML(string json)
		{
			var xml = XDocument.Load(JsonReaderWriterFactory.CreateJsonReader(
			Encoding.ASCII.GetBytes(json), new XmlDictionaryReaderQuotas()));
			return xml.ToString();
		}
	}
}
