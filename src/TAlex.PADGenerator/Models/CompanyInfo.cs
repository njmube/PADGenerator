using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Company_Info section in PAD file.
    /// </summary>
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

        /// <summary>
        /// Gets or sets the state, province or region.
        /// </summary>
        [XmlElement(ElementName = "State_Province")]
        [RegularExpression(@"^[a-zA-Z\xbc-\xff0-9 .\-,\/]*$")]
        [StringLength(30, MinimumLength = 0)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the ZIP or Postal code.
        /// </summary>
        [XmlElement(ElementName = "Zip_Postal_Code")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(20, MinimumLength = 0)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [XmlElement(ElementName = "Country")]
        [RegularExpression(@"^[a-z A-Z\xbc-\xff\x27-]*$")]
        [StringLength(40, MinimumLength = 2)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the company website URL.
        /// </summary>
        [XmlElement(ElementName = "Company_WebSite_URL")]
        [RegularExpression(@"^http:\/\/.*$")]
        [StringLength(120, MinimumLength = 2)]
        public string WebSiteUrl { get; set; }

        /// <summary>
        /// Gets or sets the contact info section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Contact_Info")]
        public ContactInfo ContactInfo { get; set; }

        /// <summary>
        /// Gets or sets the support info section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Support_Info")]
        public SupportInfo SupportInfo { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.CompanyInfo"/> class.
        /// </summary>
        public CompanyInfo()
        {
            Name = String.Empty;
            FirstAddress = String.Empty;
            SecondAddress = String.Empty;
            City = String.Empty;
            State = String.Empty;
            Zip = String.Empty;
            Country = String.Empty;
            WebSiteUrl = String.Empty;

            ContactInfo = new ContactInfo();
            SupportInfo = new SupportInfo();
        }
    }
}
