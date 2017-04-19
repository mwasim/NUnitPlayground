using NUnit.Framework;
using System;

namespace NUnitExamples
{
    [TestFixture]
    public class DateTimeEqualityTests
    {
        DateTimeEqualityDemo sut;

        [SetUp]
        public void Setup()
        {
            sut = new DateTimeEqualityDemo();
        }

        [Test]
        public void ShouldHaveCorrectSpecialDate()
        {
            var specificDate = new DateTime(2081, 1, 1, 0, 0, 0, 0);

            var result = sut.GetSpecialDate(true);

            Assert.That(result, Is.EqualTo(specificDate));
        }

        [Test]
        public void ShouldHavCorrectSpecialDate_WithTolerance()
        {
            var specificDate = new DateTime(2081, 1, 1, 0, 0, 0, 1);

            var result = sut.GetSpecialDate(true);

            //Assert.That(result, Is.EqualTo(specificDate));
            
            //Successful
            //Milliseconds tolerance
            //Assert.That(result, Is.EqualTo(specificDate).Within(TimeSpan.FromMilliseconds(1)));

            //Fluent syntax
            Assert.That(result, Is.EqualTo(specificDate).Within(1).Milliseconds);
        }


        [TearDown]
        public void Teardown()
        {
            sut = null;
        }
    }
}
