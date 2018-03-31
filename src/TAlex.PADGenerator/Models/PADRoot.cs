using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the root XML_DIZ_INFO section in PAD file.
    /// </summary>
    [XmlRoot(ElementName = "XML_DIZ_INFO")]
    public class PADRoot
    {
        /// <summary>
        /// Gets or sets the version info section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "MASTER_PAD_VERSION_INFO")]
        public VersionInfo VersionInfo { get; set; }

        /// <summary>
        /// Gets or sets the company info section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Company_Info")]
        public CompanyInfo CompanyInfo { get; set; }

        /// <summary>
        /// Gets or sets the program info section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Program_Info")]
        public ProgramInfo ProgramInfo { get; set; }

        /// <summary>
        /// Gets or sets the program descriptions section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Program_Descriptions")]
        public ProgramDescriptions ProgramDescriptions { get; set; }

        /// <summary>
        /// Gets or sets the web info section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Web_Info")]
        public WebInfo WebInfo { get; set; }

        /// <summary>
        /// Gets or sets the permissions section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Permissions")]
        public Permissions Permissions { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.PADRoot"/> class.
        /// </summary>
        public PADRoot()
        {
            VersionInfo = new VersionInfo();
            CompanyInfo = new CompanyInfo();
            ProgramInfo = new ProgramInfo();
            ProgramDescriptions = new ProgramDescriptions();
            WebInfo = new WebInfo();
            Permissions = new Permissions();
        }
    }
}
