using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Program_Info section in PAD file.
    /// </summary>
    public class ProgramInfo
    {
        /// <summary>
        /// Gets or sets the full name of the program WITHOUT version numbers.
        /// </summary>
        [XmlElement(ElementName = "Program_Name")]
        [Required]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(40, MinimumLength = 1)]
        public string ProgramName { get; set; }

        /// <summary>
        /// Gets or sets the version number of the product, should NOT contain the 'v.'.
        /// </summary>
        [XmlElement(ElementName = "Program_Version")]
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.\-]*$")]
        [StringLength(15, MinimumLength = 1)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the month that the program was released. Must be 2 digits: 01-12.
        /// </summary>
        [XmlElement(ElementName = "Program_Release_Month")]
        [RegularExpression(@"^(0[1-9]|1[0-2])$")]
        [StringLength(2, MinimumLength = 2)]
        public string ReleaseMonth { get; set; }

        /// <summary>
        /// Gets or sets the day of the month the program was released. Must be 2 digits: 01-31.
        /// </summary>
        [XmlElement(ElementName = "Program_Release_Day")]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])$")]
        [StringLength(2, MinimumLength = 2)]
        public string ReleaseDay { get; set; }

        /// <summary>
        /// Gets or sets the year the program was released. Must be a 4 digit year: 1900-2199.
        /// </summary>
        [XmlElement(ElementName = "Program_Release_Year")]
        [RegularExpression(@"^(19|20|21)[0-9]{2}$")]
        [StringLength(4, MinimumLength = 4)]
        public string ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the numerical cost of the program in US Dollars, without currency.
        /// </summary>
        [XmlElement(ElementName = "Program_Cost_Dollars")]
        [RegularExpression(@"^([0-9]+(\.[0-9]{2})?)?$")]
        public string CostAmount { get; set; }

        /// <summary>
        /// Gets or sets the international code used for Cost other.
        /// </summary>
        [XmlElement(ElementName = "Program_Cost_Other_Code")]
        [RegularExpression(
            @"^(AED|AFN|ALL|AMD|ANG|AOA|ARS|AUD|AWG|AZM|BAM|BBD|BDT|BGN|BHD|BIF|" +
            "BMD|BND|BOB|BRL|BSD|BTN|BWP|BYR|BZD|CAD|CDF|CHF|CLP|CNY|COP|COU|CRC|" +
            "CSD|CZK|CUP|CVE|CYP|DJF|DKK|DOP|DZD|EEK|EGP|ERN|ETB|EUR|FJD|FKP|GBP|" +
            "GEL|GHC|GIP|GMD|GNF|GTQ|GYD|HKD|HNL|HRK|HTG|HUF|IDR|ILS|INR|IQD|IRR|" +
            "ISK|JMD|JOD|JPY|KES|KGS|KHR|KMF|KPW|KRW|KWD|KYD|KZT|LAK|LBP|LKR|LRD|" +
            "LSL|LTL|LVL|LYD|MAD|MDL|MGA|MKD|MMK|MNT|MOP|MRO|MTL|MUR|MVR|MWK|MXN|" +
            "MYR|MZN|NAD|NGN|NIO|NOK|NPR|NZD|OMR|PAB|PEN|PGK|PHP|PKR|PLN|PYG|QAR|" +
            "RON|RUB|RWF|SAR|SBD|SCR|SDD|SEK|SGD|SHP|SIT|SKK|SLL|SOS|SRD|STD|SYP|" +
            "SZL|THB|TJS|TMM|TND|TOP|TRY|TTD|TWD|TZS|UAH|UGX|USD|UYU|UZS|VEB|VND|" +
            "VUV|WST|XAF|XCD|XOF|XPF|YER|ZAR|ZMK|ZWD)?$")]
        public string CostOtherCode { get; set; }

        /// <summary>
        /// Gets or sets the numerical cost of the program in currency other than US Dollars, without currency symbol.
        /// </summary>
        [XmlElement(ElementName = "Program_Cost_Other")]
        [RegularExpression(@"^([0-9]+(\.[0-9]{2})?)?$")]
        public string CostOther { get; set; }

        /// <summary>
        /// Gets or sets the type of program.
        /// </summary>
        [XmlElement(ElementName = "Program_Type")]
        [RegularExpression(@"^(Shareware|Freeware|Adware|Demo|Commercial|Data Only)$")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the release status of the program.
        /// </summary>
        [XmlElement(ElementName = "Program_Release_Status")]
        [RegularExpression(@"^(Major Update|Minor Update|New Release|Beta|Alpha|Media Only)$")]
        public string ReleaseStatus { get; set; }

        /// <summary>
        /// Gets or sets the type of install support the program has.
        /// </summary>
        [XmlElement(ElementName = "Program_Install_Support")]
        [RegularExpression(@"^(Install and Uninstall|Install Only|No Install Support|Uninstall Only)$")]
        public string InstallSupport { get; set; }

        /// <summary>
        /// Gets or sets the operating systems supported by the program.
        /// </summary>
        [XmlElement(ElementName = "Program_OS_Support")]
        [RegularExpression(
            @"^((Android|BlackBerry|Handheld\/Mobile Other|" +
            "iPhone|iPod|iTouch|Java|Linux|Linux Console|Linux Gnome|" +
            "Linux GPL|Linux Open Source|Mac OS X|Mac Other|" +
            "MS-DOS|Netware|OpenVMS|Palm|Pocket PC|" +
            "Symbian|Unix|Win2000|Win7 x32|Win7 x64|" +
            "Win98|WinMobile|WinOther|WinServer|WinVista|WinVista x64|" +
            "WinXP|Other|Not Applicable)[, ]*)+$")]
        public string OperatingSystems { get; set; }

        /// <summary>
        /// Gets or sets the languages supported by the program user interface.
        /// </summary>
        [XmlElement(ElementName = "Program_Language")]
        [RegularExpression(
            @"^(Abkhazian|Afar|Afrikaans|Albanian|Amharic|Arabic|Armenian|Assamese|" +
            "Aymara|Azerbaijani|Bashkir|Basque|Bengali|Bhutani|Bihari|Bislama|" +
            "Breton|Bulgarian|Burmese|Byelorussian|Cambodian|Catalan|Chinese|" +
            "ChineseSimplified|ChineseTraditional|Corsican|Croatian|Czech|" +
            "Danish|Dutch|English|Esperanto|Estonian|Faeroese|Fiji|Finnish|" +
            "French|Frisian|Gaelic|Galician|Georgian|German|Greek|Greenlandic|" +
            "Guarani|Gujarati|Hausa|Hebrew|Hindi|Hungarian|Icelandic|Indonesian|" +
            "Interlingua|Interlingue|Inupiak|Irish|Italian|Japanese|Javanese|" +
            "Kannada|Kashmiri|Kazakh|Kinyarwanda|Kirghiz|Kirundi|Korean|Kurdish|" +
            "Laothian|Latin|Latvian|Lingala|Lithuanian|Macedonian|Malagasy|Malay|" +
            "Malayalam|Maltese|Maori|Marathi|Moldavian|Mongolian|Nauru|Nepali|" +
            "Norwegian|Occitan|Oriya|Oromo|Other|Pashto|Persian|Polish|Portuguese|" +
            "Punjabi|Quechua|Rhaeto-Romance|Romanian|Russian|Samoan|Sangro|" +
            "Sanskrit|Serbian|Serbo-Croatian|Sesotho|Setswana|Shona|Sindhi|" +
            "Singhalese|Siswati|Slovak|Slovenian|Somali|Spanish|Sudanese|Swahili|" +
            "Swedish|Tagalog|Tajik|Tamil|Tatar|Telugu|Thai|Tibetan|Tigrinya|Tonga|" +
            "Tsonga|Turkish|Turkmen|Twi|Ukrainian|Urdu|Uzbek|Vietnamese|Volapuk|" +
            "Welsh|Wolof|Xhosa|Yiddish|Yoruba|Zulu|,)+$")]
        public string Languages { get; set; }

        [XmlElement(ElementName = "File_Info")]
        public FileInfo FileInfo { get; set; }

        [XmlElement(ElementName = "Expire_Info")]
        public ExpireInfo ExpireInfo { get; set; }

        /// <summary>
        /// Gets or sets the changes since the last release.
        /// </summary>
        [XmlElement(ElementName = "Program_Change_Info")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(300, MinimumLength = 0)]
        public string ChangeInfo { get; set; }

        /// <summary>
        /// Gets or sets category class that best fits the application.
        /// </summary>
        [XmlElement(ElementName = "Program_Category_Class")]
        [Required]
        [RegularExpression(
            @"^(Audio & Multimedia::Audio Encoders\/Decoders|" +
            @"Audio & Multimedia::Audio File Players|" +
            @"Audio & Multimedia::Audio File Recorders|" +
            @"Audio & Multimedia::CD Burners|" +
            @"Audio & Multimedia::CD Players|" +
            @"Audio & Multimedia::Multimedia Creation Tools|" +
            @"Audio & Multimedia::Music Composers|" +
            @"Audio & Multimedia::Other|" +
            @"Audio & Multimedia::Presentation Tools|" +
            @"Audio & Multimedia::Rippers & Converters|" +
            @"Audio & Multimedia::Speech|" +
            @"Audio & Multimedia::Video Tools|" +
            @"Business::Accounting & Finance|" +
            @"Business::Calculators & Converters|" +
            @"Business::Databases & Tools|" +
            @"Business::Helpdesk & Remote PC|" +
            @"Business::Inventory & Barcoding|" +
            @"Business::Investment Tools|" +
            @"Business::Math & Scientific Tools|" +
            @"Business::Office Suites & Tools|" +
            @"Business::Other|" +
            @"Business::PIMS & Calendars|" +
            @"Business::Project Management|" +
            @"Business::Vertical Market Apps|" +
            @"Communications::Chat & Instant Messaging|" +
            @"Communications::Dial Up & Connection Tools|" +
            @"Communications::E-Mail Clients|" +
            @"Communications::E-Mail List Management|" +
            @"Communications::Fax Tools|" +
            @"Communications::Newsgroup Clients|" +
            @"Communications::Other Comms Tools|" +
            @"Communications::Other E-Mail Tools|" +
            @"Communications::Pager Tools|" +
            @"Communications::Telephony|" +
            @"Communications::Web\/Video Cams|" +
            @"Desktop::Clocks & Alarms|" +
            @"Desktop::Cursors & Fonts|" +
            @"Desktop::Icons|" +
            @"Desktop::Other|" +
            @"Desktop::Screen Savers: Art|" +
            @"Desktop::Screen Savers: Cartoons|" +
            @"Desktop::Screen Savers: Nature|" +
            @"Desktop::Screen Savers: Other|" +
            @"Desktop::Screen Savers: People|" +
            @"Desktop::Screen Savers: Science|" +
            @"Desktop::Screen Savers: Seasonal|" +
            @"Desktop::Screen Savers: Vehicles|" +
            @"Desktop::Themes & Wallpaper|" +
            @"Development::Active X|" +
            @"Development::Basic, VB, VB DotNet|" +
            @"Development::C \/ C\+\+ \/ C\#|" +
            @"Development::Compilers & Interpreters|" +
            @"Development::Components & Libraries|" +
            @"Development::Debugging|" +
            @"Development::Delphi|" +
            @"Development ::Help Tools|" +
            @"Development::Install & Setup|" +
            @"Development::Management & Distribution|" +
            @"Development::Other|" +
            @"Development::Source Editors|" +
            @"Education::Computer|" +
            @"Education::Dictionaries|" +
            @"Education::G eography|" +
            @"Education::Kids|" +
            @"Education::Languages|" +
            @"Education::Mathema tics|" +
            @"Education::Other|" +
            @"Education::Reference Tools|" +
            @"Education::Science|" +
            @"Education::Teaching & Training Tools|" +
            @"Games & Entertainment::Action|" +
            @"Games & Entertainment::Adventure & Roleplay|" +
            @"Games & Entertainment::Arcade|" +
            @"Games & Entertainment::Board|" +
            @"Games & Entertainment::Card|" +
            @"Games & Entertainment::Casino & Gambling|" +
            @"Games & Entertainment::Kids|" +
            @"Games & Entertainment::Online Gaming|" +
            @"Games & Entertainment::Other|" +
            @"Games & Entertainment::Puzzle & Word Games|" +
            @"Games & Entertainment::Simulation|" +
            @"Games & Entertainment::Sports|" +
            @"Games & Entertainment::Strategy & War Games|" +
            @"Games & Entertainment::Tools & Editors|" +
            @"Graphic Apps::Animation Tools|" +
            @"Graphic Apps::CAD|" +
            @"Graphic Apps::Converters & Optimizers|" +
            @"Graphic Apps::Editors|" +
            @"Graphic Apps::Font Tools|" +
            @"Graphic Apps::Gallery & Cataloging Tools|" +
            @"Graphic Apps::Icon Tools|" +
            @"Graphic Apps::Other|" +
            @"Graphic Apps::Screen Capture|" +
            @"Graphic Apps::Viewers|" +
            @"Home & Hobby::Astrology\/Biorhythms\/Mystic|" +
            @"Home & Hobby::Astronomy|" +
            @"Home & Hobby::Cataloging|" +
            @"Home & Hobby::Food & Drink|" +
            @"Home & Hobby::Genealogy|" +
            @"Home & Hobby::Health & Nutrition|" +
            @"Home & Hobby::Other|" +
            @"Home & Hobby::Personal Finance|" +
            @"Home & Hobby::Personal Interest|" +
            @"Home & Hobby::Recreation|" +
            @"Home & Hobby::Religion|" +
            @"Network & Internet::Ad Blockers|" +
            @"Network & Internet::Browser Tools|" +
            @"Network & Internet::Browsers|" +
            @"Network & Internet::Download Managers|" +
            @"Network & Internet::File Sharing\/Peer to Peer|" +
            @"Network & Internet::FTP Clients|" +
            @"Network & Internet::Network Monitoring|" +
            @"Network & Internet::Other|" +
            @"Network & Internet::Remote Computing|" +
            @"Network & Internet::Search\/Lookup Tools|" +
            @"Network & Internet::Terminal & Telnet Clients|" +
            @"Network & Internet::Timers & Time Synch|" +
            @"Network & Internet::Trace & Ping Tools|" +
            @"Security & Privacy::Access Control|" +
            @"Security & Privacy::Anti-Spam & Anti-Spy Tools|" +
            @"Security & Privacy::Anti-Virus Tools|" +
            @"Security & Privacy::Covert Surveillance|" +
            @"Security & Privacy::Encryption Tools|" +
            @"Security & Privacy::Other|" +
            @"Security & Privacy::Password Managers|" +
            @"Servers::Firewall & Proxy Servers|" +
            @"Servers::FTP Servers|" +
            @"Servers::Mail Servers|" +
            @"Servers::News Servers|" +
            @"Servers::Other Server Applications|" +
            @"Servers::Telnet Servers|" +
            @"Servers::Web Servers|" +
            @"System Utilities::Automation Tools|" +
            @"System Utilities::Backup & Restore|" +
            @"System Utilities::Benchmarking|" +
            @"System Utilities::Clipboard Tools|" +
            @"System Utilities::File & Disk Management|" +
            @"System Utilities::File Compression|" +
            @"System Utilities::Launchers & Task Managers|" +
            @"System Utilities::Other|" +
            @"System Utilities::Printer|" +
            @"System Utilities::Registry Tools|" +
            @"System Utilities::Shell Tools|" +
            @"System Utilities::System Maintenance|" +
            @"System Utilities::Text\/Document Editors|" +
            @"Web Development::ASP & PHP|" +
            @"Web Development::E-Commerce|" +
            @"Web Development::Flash Tools|" +
            @"Web Development::HTML Tools|" +
            @"Web Development::Java & JavaScript|" +
            @"Web Development::Log Analysers|" +
            @"Web Development::Other|" +
            @"Web Development::Site Administration|" +
            @"Web Development::Wizards & Components|" +
            @"Web Development::XML\/CSS Tools)$")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the overall category that best fits the application, DEPRECATED.
        /// </summary>
        [XmlElement(ElementName = "Program_Specific_Category")]
        [RegularExpression(
            @"^(Audio|" +
            @"Business|" +
            @"Development Tools|" +
            @"Education|" +
            @"Games|" +
            @"Graphics|" +
            @"Home\/Hobby|" +
            "Internet|" +
            "Miscellaneous|" +
            "Screen Savers|" +
            "Utilities)?$")]
        public string SpecificCategory { get; set; }

        /// <summary>
        /// Gets or sets the minimum system requirements.
        /// </summary>
        [XmlElement(ElementName = "Program_System_Requirements")]
        [RegularExpression(@"^[^<\x09]*$")]
        [StringLength(100, MinimumLength = 0)]
        public string SystemRequirements { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.ProgramInfo"/> class.
        /// </summary>
        public ProgramInfo()
        {
            ProgramName = String.Empty;
            Version = String.Empty;
            ReleaseMonth = String.Empty;
            ReleaseDay = String.Empty;
            ReleaseYear = String.Empty;
            CostAmount = String.Empty;
            CostOtherCode = String.Empty;
            CostOther = String.Empty;
            Type = String.Empty;
            ReleaseStatus = String.Empty;
            InstallSupport = String.Empty;
            OperatingSystems = String.Empty;
            Languages = String.Empty;
            FileInfo = new FileInfo();
            ExpireInfo = new ExpireInfo();
            ChangeInfo = String.Empty;
            Category = String.Empty;
            SpecificCategory = String.Empty;
            SystemRequirements = String.Empty;
        }


        #region Helpers

        public void SetReleaseDate(DateTime date)
        {
            ReleaseDay = date.Day.ToString("D2");
            ReleaseMonth = date.Month.ToString("D2");
            ReleaseYear = date.Year.ToString("D2");
        }

        #endregion
    }
}
