using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TAlex.PADGenerator.Models;
using FluentAssertions;

namespace TAlex.PADGenerator.Test
{
    [TestFixture]
    public class BasicPADGeneratorTests
    {
        private IPADGenerator _generator;

        [SetUp]
        public void SetUp()
        {
            _generator = new BasicPADGenerator();
        }

        [Test]
        public void Generate_Success()
        {
            //arrange
            PADRoot root = new PADRoot();
            root.ProgramDescriptions.Add("English", new ProgramDescription());
            MemoryStream stream = new MemoryStream();

            //action
            _generator.Generate(root, stream);
            stream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();

            // assert
            text.Should().NotBeEmpty();
        }
    }
}
