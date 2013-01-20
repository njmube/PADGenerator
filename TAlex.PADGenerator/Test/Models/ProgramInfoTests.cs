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
    public class ProgramInfoTests
    {
        private ProgramInfo _model;


        [SetUp]
        public void SetUp()
        {
            _model = new ProgramInfo();
        }


        [Test]
        public void SetReleaseDate_Success()
        {
            // arrange
            DateTime date = new DateTime(2013, 1, 9);

            // action
            _model.SetReleaseDate(date);

            // assert
            int.Parse(_model.ReleaseDay).Should().Be(date.Day);
            int.Parse(_model.ReleaseMonth).Should().Be(date.Month);
            int.Parse(_model.ReleaseYear).Should().Be(date.Year);
        }
    }
}
