using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;


namespace TAlex.PADGenerator.Models
{
    /// <summary>
    /// Represents the XML_DIZ_INFO/Program_Info/File_Info section in PAD file.
    /// </summary>
    public class FileInfo
    {
        /// <summary>
        /// Gets or sets the size of the distribution file in Bytes.
        /// </summary>
        [XmlElement(ElementName = "File_Size_Bytes")]
        [RegularExpression(@"^[0-9]*$")]
        [StringLength(16, MinimumLength = 3)]
        public string FileSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the size of the distribution file in Kilobytes.
        /// </summary>
        [XmlElement(ElementName = "File_Size_K")]
        [RegularExpression(@"^[0-9.]*$")]
        [StringLength(12, MinimumLength = 1)]
        public string FileSizeKilobytes { get; set; }

        /// <summary>
        /// Gets or sets the size of the distribution file in Megabytes.
        /// </summary>
        [XmlElement(ElementName = "File_Size_MB")]
        [RegularExpression(@"^[0-9.]*$")]
        [StringLength(8, MinimumLength = 1)]
        public string FileSizeMegabytes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TAlex.PADGenerator.Models.FileInfo"/> class.
        /// </summary>
        public FileInfo()
        {
            FileSizeBytes = String.Empty;
            FileSizeKilobytes = String.Empty;
            FileSizeMegabytes = String.Empty;
        }


        #region Helpers

        /// <summary>
        /// Sets the file size (bytes, kilobytes and megabytes) of the distribution file.
        /// </summary>
        /// <param name="sizeInBytes">An <see cref="System.Int32"/> integer that represents the file size in bytes.</param>
        public void SetFileSize(int sizeInBytes)
        {
            FileSizeBytes = sizeInBytes.ToString();
            FileSizeKilobytes = (sizeInBytes / 1024).ToString();
            FileSizeMegabytes = Math.Round(sizeInBytes / 1048576.0, 2).ToString();
        }

        #endregion
    }
}
