using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Program_Descriptions section in PAD file.
    /// </summary>
    public class ProgramDescriptions : IXmlSerializable
    {
        private XmlSerializer _serializer = new XmlSerializer(typeof(ProgramDescription));

        /// <summary>
        /// Gets the dictionary with program descriptions for differents languages.
        /// </summary>
        public Dictionary<string, ProgramDescription> Descriptions { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.ProgramDescriptions"/> class.
        /// </summary>
        public ProgramDescriptions()
        {
            Descriptions = new Dictionary<string, ProgramDescription>();
        }

        /// <summary>
        /// Adds the program description with the specified language to the dictionary.
        /// </summary>
        /// <param name="language">A <see cref="System.String"/> that represents the language of program description.</param>
        /// <param name="description">A <see cref="TAlex.PADGenerator.Models.ProgramDescription"/> that represents the program description.</param>
        public void Add(string language, ProgramDescription description)
        {
            Descriptions.Add(language, description);
        }

        #region IXmlSerializable Members

        /// <summary>
        /// This method is reserved and should not be used.
        /// </summary>
        /// <returns>null.</returns>
        public XmlSchema GetSchema()
        {
            return null;
        }

        /// <summary>
        /// Generates an object from its XML representation. Currently is not implementing.
        /// </summary>
        /// <param name="reader">The <see cref="System.Xml.XmlReader"/> stream from which the object is deserialized.</param>
        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts an object into its XML representation.
        /// </summary>
        /// <param name="writer">The <see cref="System.Xml.XmlWriter"/> stream to which the object is serialized.</param>
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
