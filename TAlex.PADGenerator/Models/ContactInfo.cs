using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Company_Info/Contact_Info section in PAD file.
    /// </summary>
    public class ContactInfo
    {
        /// <summary>
        /// Gets or sets the author's first name.
        /// </summary>
        [XmlElement(ElementName = "Author_First_Name")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(30, MinimumLength = 2)]
        public string AuthorFirstName { get; set; }

        /// <summary>
        /// Gets or sets the author's last name.
        /// </summary>
        [XmlElement(ElementName = "Author_Last_Name")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(30, MinimumLength = 2)]
        public string AuthorLastName { get; set; }

        /// <summary>
        /// Gets or sets the author's email address.
        /// </summary>
        [XmlElement(ElementName = "Author_Email")]
        [RegularExpression(Patterns.Email)]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// Gets or sets first name of the person that should be used to contact the company regarding this product.
        /// </summary>
        [XmlElement(ElementName = "Contact_First_Name")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(30, MinimumLength = 2)]
        public string ContactFirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person that should be used to contact the company regarding this product.
        /// </summary>
        [XmlElement(ElementName = "Contact_Last_Name")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(30, MinimumLength = 2)]
        public string ContactLastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the person that should be used to contact the company regarding this product.
        /// </summary>
        [XmlElement(ElementName = "Contact_Email")]
        [RegularExpression(Patterns.Email)]
        public string ContactEmail { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.ContactInfo"/> class.
        /// </summary>
        public ContactInfo()
        {
            AuthorFirstName = String.Empty;
            AuthorLastName = String.Empty;
            AuthorEmail = String.Empty;
            ContactFirstName = String.Empty;
            ContactLastName = String.Empty;
            ContactEmail = String.Empty;
        }
    }
}
