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


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.WebInfo"/> class.
        /// </summary>
        public WebInfo()
        {
            ApplicationURLs = new ApplicationURLs();
            DownloadURLs = new DownloadURLs();
        }
    }
}
