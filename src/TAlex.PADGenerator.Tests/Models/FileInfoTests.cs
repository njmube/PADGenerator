using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAlex.PADGenerator.Models;
using FluentAssertions;

namespace TAlex.PADGenerator.Tests.Models
{
    [TestFixture]
    public class FileInfoTests
    {
        protected FileInfo Model;


        [SetUp]
        public void SetUp()
        {
            Model = new FileInfo();
        }

        #region SetFileSize

        [TestCase(286068, "279", "0.27")]
        [TestCase(1048576, "1024", "1")]
        public void SetFileSize_IntSize_Success(int size, string expectedSizeKilobytes, string expectedSizeMegabytes)
        {
            // action
            Model.SetFileSize(size);

            // assert
            Model.FileSizeBytes.Should().Be(size.ToString());
            Model.FileSizeKilobytes.Should().Be(expectedSizeKilobytes);
            Model.FileSizeMegabytes.Should().Be(expectedSizeMegabytes);
        }

        #endregion
    }
}
