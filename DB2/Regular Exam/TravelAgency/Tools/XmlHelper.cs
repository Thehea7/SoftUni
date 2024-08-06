using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TravelAgency.Tools
{
    public class XmlHelper
    {
        public T Deserialize<T>(string inputXml, string rootName) where T : class
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            object deserializedObject = xmlSerializer.Deserialize(stringReader);

            if (deserializedObject == null || deserializedObject is not T deserializedObjectTypes)
            {
                throw new InvalidOperationException("xmlCustomHelper FuckedUp");
            }

            return deserializedObjectTypes;

        }

        public string Serialize<T>(T obj, string rootName)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), xmlRoot);

            XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
            xmlSerializerNamespaces.Add(string.Empty, string.Empty);

            using StringWriter stringWriter = new StringWriter(sb);
            xmlSerializer.Serialize(stringWriter, obj, xmlSerializerNamespaces);

            return sb.ToString().TrimEnd();

        }
    }
}
