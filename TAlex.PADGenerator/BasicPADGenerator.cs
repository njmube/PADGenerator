using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using TAlex.PADGenerator.Helpers;
using TAlex.PADGenerator.Models;

namespace TAlex.PADGenerator
{
    public class BasicPADGenerator : IPADGenerator
    {
        private XmlSerializerNamespaces _namespaces;
        private XmlWriterSettings _xmlSettings;


        public BasicPADGenerator()
        {
            _namespaces = new XmlSerializerNamespaces();
            _namespaces.Add(String.Empty, String.Empty);
            
            _xmlSettings = new XmlWriterSettings
            {
                OmitXmlDeclaration = false,
                NewLineOnAttributes = true,
                Indent = true
            };
        }


        #region IPADGenerator Members

        public void Generate(PADRoot root, Stream output)
        {
            // Validate
            List<ValidationResult> results = new List<ValidationResult>();
            if (!DataAnnotationsValidator.TryValidateObjectRecursive(root, results))
            {
                ValidationResult result = results.First();
                throw new ValidationException(result, null, null);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(PADRoot));

            XmlWriter writer = XmlWriter.Create(output, _xmlSettings);
            serializer.Serialize(writer, root, _namespaces);
        }

        #endregion
    }
}
