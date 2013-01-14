using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class CompanyInfo
    {
        /// <summary>
        /// Gets or sets the company name or, if no company name, author name.
        /// </summary>
        [XmlElement(ElementName = "Company_Name")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(40, MinimumLength = 2)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the first line of the mailing address.
        /// </summary>
        [XmlElement(ElementName = "Address_1")]
        [RegularExpression(@"^[a-zA-Z0-9\xbc-\xff .\-,#\/\x27]*$")]
        [StringLength(40, MinimumLength = 0)]
        public string FirstAddress { get; set; }

        /// <summary>
        /// Gets or sets the second line of the mailing address, optional.
        /// </summary>
        [XmlElement(ElementName = "Address_2")]
        [RegularExpression(@"^[a-zA-Z\xbc-\xff0-9 .\-,#\/\x27]*$")]
        [StringLength(40, MinimumLength = 0)]
        public string SecondAddress { get; set; }

        /// <summary>
        /// Gets or sets the city, town or village.
        /// </summary>
        [XmlElement(ElementName = "City_Town")]
        [RegularExpression(@"^[a-zA-Z\xbc-\xff0-9 .\-,#\/\x27]*$")]
        [StringLength(40, MinimumLength = 2)]
        public string City { get; set; }




        public CompanyInfo()
        {
            Name = String.Empty;
            FirstAddress = String.Empty;
            SecondAddress = String.Empty;
            City = String.Empty;
        }
    }
}
