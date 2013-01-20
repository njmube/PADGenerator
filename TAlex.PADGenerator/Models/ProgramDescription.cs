using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class ProgramDescription
    {
        /// <summary>
        /// Gets or sets the keywords to be used to describe the program, comma delimited.
        /// </summary>
        [XmlElement(ElementName = "Keywords")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(250, MinimumLength = 0)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets the 45 character description of the program (no HTML).
        /// </summary>
        [XmlElement(ElementName = "Char_Desc_45")]
        [RegularExpression(@"^[^<\x09\x0a\x0d]*$")]
        [StringLength(45, MinimumLength = 0)]
        public string Description45 { get; set; }

        /// <summary>
        /// Gets or sets the 80 character description of the program (no HTML).
        /// </summary>
        [XmlElement(ElementName = "Char_Desc_80")]
        [RegularExpression(@"^[^<\x09\x0a\x0d]*$")]
        [StringLength(80, MinimumLength = 0)]
        public string Description80 { get; set; }

        /// <summary>
        /// Gets or sets the 250 character description of the program (no HTML).
        /// </summary>
        [XmlElement(ElementName = "Char_Desc_250")]
        [RegularExpression(@"^[^<\x09\x0a\x0d]*$")]
        [StringLength(250, MinimumLength = 0)]
        public string Description250 { get; set; }

        /// <summary>
        /// Gets or sets the 450 character description of the program (no HTML).
        /// </summary>
        [XmlElement(ElementName = "Char_Desc_450")]
        [RegularExpression(@"^[^<\x09\x0a\x0d]*$")]
        [StringLength(450, MinimumLength = 0)]
        public string Description450 { get; set; }

        /// <summary>
        /// Gets or sets the 2000 character description of the program (no HTML).
        /// </summary>
        [XmlElement(ElementName = "Char_Desc_2000")]
        [RegularExpression(@"^[^<]*$")]
        [StringLength(2000, MinimumLength = 0)]
        public string Description2000 { get; set; }


        public ProgramDescription()
        {
            Keywords = String.Empty;
            Description45 = String.Empty;
            Description80 = String.Empty;
            Description250 = String.Empty;
            Description450 = String.Empty;
            Description2000 = String.Empty;
        }
    }
}
