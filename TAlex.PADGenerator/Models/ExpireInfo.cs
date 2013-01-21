using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class ExpireInfo
    {
        /// <summary>
        /// Gets or sets the value that used to determine if the program has expiration parameters.
        /// </summary>
        [XmlElement(ElementName = "Has_Expire_Info")]
        [RegularExpression(@"^[YyNn]$")]
        public string HasExpireInfo { get; set; }

        /// <summary>
        /// Gets or sets the number of days or uses until program expires.
        /// </summary>
        [XmlElement(ElementName = "Expire_Count")]
        [RegularExpression(@"^[0-9]*$")]
        [StringLength(15, MinimumLength = 0)]
        public string ExpireCount { get; set; }

        /// <summary>
        /// Gets or sets the type of expiration.
        /// </summary>
        [XmlElement(ElementName = "Expire_Based_On")]
        [RegularExpression(@"^(Days|Uses|Either\/Or)?$")]
        public string ExpireBasedOn { get; set; }
        
        /// <summary>
        /// Gets or sets the other important information regarding expiration of the program.
        /// </summary>
        [XmlElement(ElementName = "Expire_Other_Info")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(100, MinimumLength = 0)]
        public string ExpireOtherInfo { get; set; }

        /// <summary>
        /// Gets or sets the month that the program will expire. Must be 2 digits: 01-12.
        /// </summary>
        [XmlElement(ElementName = "Expire_Month")]
        [RegularExpression(Patterns.OptionalMonth)]
        public string ExpireMonth { get; set; }

        /// <summary>
        /// Gets or sets the day of the month the program will expire. Must be 2 digits: 01-31.
        /// </summary>
        [XmlElement(ElementName = "Expire_Day")]
        [RegularExpression(Patterns.OptionalDay)]
        public string ExpireDay { get; set; }

        /// <summary>
        /// Gets or sets the year the program will expire. Must be a 4 digit year: 1900-2199.
        /// </summary>
        [XmlElement(ElementName = "Expire_Year")]
        [RegularExpression(Patterns.OptionalYear)]
        public string ExpireYear { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.ExpireInfo"/> class.
        /// </summary>
        public ExpireInfo()
        {
            HasExpireInfo = String.Empty;
            ExpireCount = String.Empty;
            ExpireBasedOn = String.Empty;
            ExpireOtherInfo = String.Empty;
            ExpireMonth = String.Empty;
            ExpireDay = String.Empty;
            ExpireYear = String.Empty;
        }
    }
}
