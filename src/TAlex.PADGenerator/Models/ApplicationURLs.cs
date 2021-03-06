﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Web_Info/Application_URLs section in PAD file.
    /// </summary>
    public class ApplicationURLs
    {
        /// <summary>
        /// Gets or sets the url used to point people to get more information about the program.
        /// </summary>
        [XmlElement(ElementName = "Application_Info_URL")]
        [RegularExpression(@"^https?:\/\/.{2,120}$")]
        public string InfoUrl { get; set; }

        /// <summary>
        /// Gets or sets the url used to point people to order the program.
        /// </summary>
        [XmlElement(ElementName = "Application_Order_URL")]
        [RegularExpression(@"^((http|https):\/\/.{2,120})?$")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// Gets or sets the url used to access a screenshot of the program.
        /// </summary>
        [XmlElement(ElementName = "Application_Screenshot_URL")]
        [RegularExpression(@"^https?:\/\/.{2,120}\.(gif|jpg|png)$")]
        public string ScreenshotUrl { get; set; }

        /// <summary>
        /// Gets or sets the url used to access the icon image (32x32 pixels) used for the program.
        /// </summary>
        [XmlElement(ElementName = "Application_Icon_URL")]
        [RegularExpression(@"^$|^https?:\/\/.{2,120}\.(gif|jpg|png)$")]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or sets the url used to access the PAD file in the future.
        /// </summary>
        [XmlElement(ElementName = "Application_XML_File_URL")]
        [RegularExpression(@"^https?:\/\/.{2,120}\.(xml|cgi|php|asp)$")]
        public string XmlFileUrl { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.ApplicationURLs"/> class.
        /// </summary>
        public ApplicationURLs()
        {
            InfoUrl = String.Empty;
            OrderUrl = String.Empty;
            ScreenshotUrl = String.Empty;
            IconUrl = String.Empty;
            XmlFileUrl = String.Empty;
        }
    }
}
