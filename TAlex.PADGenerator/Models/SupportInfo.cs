using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace TAlex.PADGenerator.Models
{
    public class SupportInfo
    {
        /// <summary>
        /// Gets or sets the email address where sales inquiries should be directed.
        /// </summary>
        [XmlElement(ElementName = "Sales_Email")]
        [RegularExpression(Patterns.Email)]
        public string SalesEmail { get; set; }

        /// <summary>
        /// Gets or sets the email address where technical support inquiries should be directed.
        /// </summary>
        [XmlElement(ElementName = "Support_Email")]
        [RegularExpression(Patterns.Email)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Gets or sets the email address where general inquiries should be directed.
        /// </summary>
        [XmlElement(ElementName = "General_Email")]
        [RegularExpression(Patterns.Email)]
        public string GeneralEmail { get; set; }

        /// <summary>
        /// Gets or sets the phone number where sales inquiries should be directed.
        /// </summary>
        [XmlElement(ElementName = "Sales_Phone")]
        [RegularExpression(Patterns.Phone)]
        public string SalesPhone { get; set; }

        /// <summary>
        /// Gets or sets the phone number where technical support inquiries should be directed.
        /// </summary>
        [XmlElement(ElementName = "Support_Phone")]
        [RegularExpression(Patterns.Phone)]
        public string SupportPhone { get; set; }

        /// <summary>
        /// Gets or sets the phone number where general inquiries should be directed.
        /// </summary>
        [XmlElement(ElementName = "General_Phone")]
        [RegularExpression(Patterns.Phone)]
        public string GeneralPhone { get; set; }

        /// <summary>
        /// Gets or sets the fax number.
        /// </summary>
        [XmlElement(ElementName = "Fax_Phone")]
        [RegularExpression(Patterns.Phone)]
        public string FaxPhone { get; set; }


        public SupportInfo()
        {
            SalesEmail = String.Empty;
            SupportEmail = String.Empty;
            GeneralEmail = String.Empty;
            SalesPhone = String.Empty;
            SupportPhone = String.Empty;
            GeneralPhone = String.Empty;
            FaxPhone = String.Empty;
        }
    }
}
