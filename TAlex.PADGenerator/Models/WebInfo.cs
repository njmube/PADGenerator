using System;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Web_Info section in PAD file.
    /// </summary>
    public class WebInfo
    {
        /// <summary>
        /// Gets or sets the application urls section of PAD file.
        /// </summary>
        [XmlElement(ElementName = "Application_URLs")]
        public ApplicationURLs ApplicationURLs { get; set; }

        /// <summary>
        /// Gets or sets the download urls section of PAD file.
        /// </summary>
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
