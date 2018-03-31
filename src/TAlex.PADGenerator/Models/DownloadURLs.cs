using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Web_Info/Download_URLs section in PAD file.
    /// </summary>
    public class DownloadURLs
    {
        private const string DownloadUrlPattern = @"^(http|ftp)s?:\/\/.{2,120}\.(air|apk|app|bin|com|exe|dmg|hqx|gz|gzip|jar|msi|rar|sea|sh|sis|sit|sitx|tar|taz|tgx|tgz|uu|z|zip|gadget|application)$";

        /// <summary>
        /// Gets or sets the primary download URL where customers can download the program.
        /// </summary>
        [XmlElement(ElementName = "Primary_Download_URL")]
        [RegularExpression(DownloadUrlPattern)]
        public string PrimaryDownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the secondary download URL where customers can download the program.
        /// </summary>
        [XmlElement(ElementName = "Secondary_Download_URL")]
        [RegularExpression(DownloadUrlPattern)]
        public string SecondaryDownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the additional download URL where customers can download the program.
        /// </summary>
        [XmlElement(ElementName = "Additional_Download_URL_1")]
        [RegularExpression(DownloadUrlPattern)]
        public string FirstAdditionalDownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the another download URL where customers can download the program.
        /// </summary>
        [XmlElement(ElementName = "Additional_Download_URL_2")]
        [RegularExpression(DownloadUrlPattern)]
        public string SecondAdditionalDownloadUrl { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.DownloadURLs"/> class.
        /// </summary>
        public DownloadURLs()
        {
            PrimaryDownloadUrl = String.Empty;
            SecondaryDownloadUrl = String.Empty;
            FirstAdditionalDownloadUrl = String.Empty;
            SecondAdditionalDownloadUrl = String.Empty;
        }
    }
}
