using System;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    public class WebInfo
    {
        [XmlElement(ElementName = "Application_URLs")]
        public ApplicationURLs ApplicationURLs { get; set; }

        [XmlElement(ElementName = "Download_URLs")]
        public DownloadURLs DownloadURLs { get; set; }

        public WebInfo()
        {
            ApplicationURLs = new ApplicationURLs();
            DownloadURLs = new DownloadURLs();
        }
    }
}
