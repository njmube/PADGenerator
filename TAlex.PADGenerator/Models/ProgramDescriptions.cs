using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class ProgramDescriptions : IXmlSerializable
    {
        private XmlSerializer _serializer = new XmlSerializer(typeof(ProgramDescription));

        public Dictionary<string, ProgramDescription> Descriptions { get; private set; }

        public ProgramDescriptions()
        {
            Descriptions = new Dictionary<string, ProgramDescription>();
        }


        public void Add(string language, ProgramDescription description)
        {
            Descriptions.Add(language, description);
        }

        #region IXmlSerializable Members

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            XmlDocument elementDoc = new XmlDocument();

            foreach (var item in Descriptions)
            {
                using (MemoryStream itemStream = new MemoryStream())
                {
                    _serializer.Serialize(itemStream, item.Value);
                    itemStream.Seek(0, SeekOrigin.Begin);
                    elementDoc.Load(itemStream);
                }

                XmlElement descElement = elementDoc.CreateElement(item.Key);
                descElement.InnerXml = elementDoc.DocumentElement.InnerXml;

                descElement.WriteTo(writer);
            }
        }

        #endregion
    }
}
