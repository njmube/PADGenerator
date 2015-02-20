using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TAlex.PADGenerator.Models;
using FluentAssertions;

namespace TAlex.PADGenerator.Test.Models
{
    [TestFixture]
    public class FileInfoTests
    {
        private FileInfo _model;


        [SetUp]
        public void SetUp()
        {
            _model = new FileInfo();
        }


        [Test]
        public void SetFileSize_Success()
        {
            // arrange
            int size = 286068;

            // action
            _model.SetFileSize(size);

            // assert
            _model.FileSizeBytes.Should().Be(size.ToString());
            _model.FileSizeKilobytes.Should().Be("279");
            _model.FileSizeMegabytes.Should().Be("0.27");
        }

        [Test]
        public void SetFileSize_Success2()
        {
            // arrange
            int size = 1048576;

            // action
            _model.SetFileSize(size);

            // assert
            _model.FileSizeBytes.Should().Be(size.ToString());
            _model.FileSizeKilobytes.Should().Be("1024");
            _model.FileSizeMegabytes.Should().Be("1");
        }
    }
}
