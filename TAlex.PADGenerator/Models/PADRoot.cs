using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public PADRoot()
        {
            VersionInfo = new VersionInfo();
            CompanyInfo = new CompanyInfo();
        }
    }
}
