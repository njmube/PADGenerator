using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class VersionInfo
    {
        /// <summary>
        /// Gets or sets the PAD specification version that the PAD file complies with.
        /// </summary>
        [XmlElement(ElementName = "MASTER_PAD_VERSION")]
        [RegularExpression(@"^\d.\d+$")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the name of tool producing PAD file.
        /// </summary>
        [XmlElement(ElementName = "MASTER_PAD_EDITOR")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(100, MinimumLength = 0)]
        public string Editor { get; set; }

        /// <summary>
        /// Gets or sets the information on how to find out more about PAD.
        /// </summary>
        [XmlElement(ElementName = "MASTER_PAD_INFO")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(1000, MinimumLength = 0)]
        public string Info { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.VersionInfo"/> class.
        /// </summary>
        public VersionInfo()
        {
            Version = "4.0";
            Editor = String.Format("TAlex PAD Generator {0}", Assembly.GetExecutingAssembly().GetName().Version);
            Info = "Portable Application Description, or PAD for short, is a data set that is used by shareware authors to disseminate information to anyone interested in their software products. To find out more go to http://pad.asp-software.org";
        }
    }
}
