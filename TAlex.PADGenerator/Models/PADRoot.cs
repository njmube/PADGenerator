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
        public VersionInfo PADVersionInfo { get; set; }

        [XmlElement(ElementName = "Company_Info")]
        public CompanyInfo CompanyInfo { get; set; }

        public PADRoot()
        {
            PADVersionInfo = new VersionInfo();
            CompanyInfo = new CompanyInfo();
        }
    }
}
