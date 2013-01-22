using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using TAlex.PADGenerator.Helpers;
using TAlex.PADGenerator.Models;


namespace TAlex.PADGenerator
{
    /// <summary>
    /// Represents the basic implementation of PAD file generator.
    /// </summary>
    public class BasicPADGenerator : IPADGenerator
    {
        private XmlSerializerNamespaces _namespaces;
        private XmlWriterSettings _xmlSettings;


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.BasicPADGenerator"/> class.
        /// </summary>
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

        /// <summary>
        /// Generates xml PAD file and puts to output stream.
        /// </summary>
        /// <param name="root">A root elemnt model for PAD file.</param>
        /// <param name="output">An output stream for writing generated PAD file.</param>
        public void Generate(PADRoot root, Stream output)
        {
            Validate(root);            

            XmlSerializer serializer = new XmlSerializer(typeof(PADRoot));

            XmlWriter writer = XmlWriter.Create(output, _xmlSettings);
            serializer.Serialize(writer, root, _namespaces);
        }

        #endregion

        /// <summary>
        /// Determines whether the specified PAD file model is valid.
        /// </summary>
        /// <param name="root">The object to validate.</param>
        /// <exception cref="System.ComponentModel.DataAnnotations.ValidationException">
        /// The object is not valid.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// root is null.
        /// </exception>
        public void Validate(PADRoot root)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            if (!TryValidate(root, results))
            {
                ValidationResult result = results.First();
                throw new ValidationException(result, null, null);
            }
        }

        /// <summary>
        /// Determines whether the specified PAD file model is valid using the validation results collection.
        /// </summary>
        /// <param name="root">The object to validate.</param>
        /// <param name="results">A collection to hold each failed validation.</param>
        /// <returns>true if the object validates; otherwise, false.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// root is null.
        /// </exception>
        public bool TryValidate(PADRoot root, List<ValidationResult> results)
        {
            return DataAnnotationsValidator.TryValidateObjectRecursive(root, results);
        }
    }
}
