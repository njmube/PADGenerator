using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class Permissions
    {
        /// <summary>
        /// Gets or sets the distribution permissions given by the author to vendors and other distributors.
        /// </summary>
        [XmlElement(ElementName = "Distribution_Permissions")]
        [RegularExpression(@"^[^<]*$")]
        [StringLength(2000, MinimumLength = 0)]
        public string DistributionPermissions { get; set; }

        /// <summary>
        /// Gets or sets the End User License Agreement for the program.
        /// </summary>
        [XmlElement(ElementName = "EULA")]
        [RegularExpression(@"^[^<]*$")]
        [StringLength(20000, MinimumLength = 0)]
        public string EULA { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.Permissions"/> class.
        /// </summary>
        public Permissions()
        {
            DistributionPermissions = String.Empty;
            EULA = String.Empty;
        }
    }
}
