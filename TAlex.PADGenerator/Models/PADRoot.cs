using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    [XmlRoot(ElementName = "XML_DIZ_INFO")]
    public class PADRoot
    {
        [XmlElement(ElementName = "MASTER_PAD_VERSION_INFO")]
        public VersionInfo VersionInfo { get; set; }

        [XmlElement(ElementName = "Company_Info")]
        public CompanyInfo CompanyInfo { get; set; }

        [XmlElement(ElementName = "Program_Info")]
        public ProgramInfo ProgramInfo { get; set; }

        [XmlElement(ElementName = "Program_Descriptions")]
        public ProgramDescriptions ProgramDescriptions { get; set; }

        [XmlElement(ElementName = "Web_Info")]
        public WebInfo WebInfo { get; set; }

        [XmlElement(ElementName = "Permissions")]
        public Permissions Permissions { get; set; }


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
