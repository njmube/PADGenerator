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
    public class ProgramInfoTests
    {
        protected ProgramInfo Model;


        [SetUp]
        public void SetUp()
        {
            Model = new ProgramInfo();
        }


        #region SetReleaseDate

        [Test]
        public void SetReleaseDate_DateTime_Success()
        {
            // arrange
            DateTime date = new DateTime(2013, 1, 9);

            // action
            Model.SetReleaseDate(date);

            // assert
            int.Parse(Model.ReleaseDay).Should().Be(date.Day);
            int.Parse(Model.ReleaseMonth).Should().Be(date.Month);
            int.Parse(Model.ReleaseYear).Should().Be(date.Year);
        }

        #endregion
    }
}
