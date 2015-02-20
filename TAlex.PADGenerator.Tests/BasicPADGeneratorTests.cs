using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TAlex.PADGenerator.Models;
using FluentAssertions;
using System.ComponentModel.DataAnnotations;


namespace TAlex.PADGenerator.Test
{
    [TestFixture]
    public class BasicPADGeneratorTests
    {
        protected IPADGenerator Target;
        private Stream _outputStream;
        private StreamReader _outputStreamReader;


        [SetUp]
        public void SetUp()
        {
            Target = new BasicPADGenerator();
            _outputStream = new MemoryStream();
            _outputStreamReader = new StreamReader(_outputStream);
        }

        #region Generate

        [Test]
        public void Generate_PADModel_SuccessResult()
        {
            //arrange
            PADRoot root = new PADRoot();
            root.ProgramDescriptions.Add("English", new ProgramDescription());

            root.CompanyInfo.Name = "T-Alex Software";
            root.CompanyInfo.City = "San Francisco";
            root.CompanyInfo.Country = "USA";
            root.CompanyInfo.WebSiteUrl = "http://www.talex-soft.com";
            root.CompanyInfo.ContactInfo.AuthorFirstName = "Firstname";
            root.CompanyInfo.ContactInfo.AuthorLastName = "Lastname";
            root.CompanyInfo.ContactInfo.ContactFirstName = "Firstname";
            root.CompanyInfo.ContactInfo.ContactLastName = "Lastname";
            root.ProgramInfo.ProgramName = "Cool Program";
            root.ProgramInfo.Version = "2.0";
            root.ProgramInfo.SetReleaseDate(new DateTime(2013, 1, 3));
            root.ProgramInfo.Category = "Desktop::Screen Savers: Science";
            root.ProgramInfo.FileInfo.SetFileSize(3645785);

            //action
            Target.Generate(root, _outputStream);
            _outputStream.Seek(0, SeekOrigin.Begin);
            string text = _outputStreamReader.ReadToEnd();

            // assert
            text.Should().NotBeEmpty();
        }

        [Test]
        public void Generate_PADModel_ThrowValidationException()
        {
            //arrange
            PADRoot root = new PADRoot();
            root.ProgramDescriptions.Add("English", new ProgramDescription());

            root.CompanyInfo.City = "San Francisco";
            root.CompanyInfo.Country = "USA";
            root.CompanyInfo.WebSiteUrl = "http://www.talex-soft.com";
            root.CompanyInfo.ContactInfo.AuthorFirstName = "Firstname";
            root.CompanyInfo.ContactInfo.AuthorLastName = "Lastname";
            root.CompanyInfo.ContactInfo.ContactFirstName = "Firstname";
            root.CompanyInfo.ContactInfo.ContactLastName = "Lastname";
            root.ProgramInfo.ProgramName = "Cool Program";
            root.ProgramInfo.Version = "2.0";
            root.ProgramInfo.SetReleaseDate(new DateTime(2013, 1, 3));
            root.ProgramInfo.Category = "Desktop::Screen Savers: Science";
            root.ProgramInfo.FileInfo.SetFileSize(3645785);

            //action
            Action action = () => { Target.Generate(root, _outputStream); };
            
            // assert
            action.ShouldThrow<ValidationException>()
                .WithMessage("The field Name must be a string with a minimum length of 2 and a maximum length of 40.");
        }

        #endregion
    }
}
