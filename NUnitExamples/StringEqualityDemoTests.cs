using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    [Category("String Equality Tests")]
    [TestFixture]
    public class StringEqualityDemoTests
    {
        StringEqualityDemo sut;

        [SetUp]
        public void Initialize()
        {
            Debug.WriteLine("Before each test");
            sut = new StringEqualityDemo();
        }

        [Test]
        public void ShouldJoinFirstAndLastName()
        {
            //Arrange            
            var firstname = "John";
            var lastname = "Doe";

            //Act
            var result = sut.GetFullName(firstname, lastname);
            var expectedResult = $"{firstname} {lastname}";

            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void ShouldIgnoreCase()
        {
            //Arrange            
            var firstname = "John";
            var lastname = "Doe";

            //Act 
            var result = sut.GetFullName(firstname, lastname);
            var expectedResultWithDifferentCase = $"{firstname.ToUpper()} {lastname.ToUpper()}";

            //Assert
            Assert.That(result, Is.EqualTo(expectedResultWithDifferentCase).IgnoreCase);
        }

        [Test]
        public void ShouldCheckNameMismatch()
        {
            //Arrange            
            var firstname = "John";
            var lastname = "Doe";

            //Act
            var result = sut.GetFullName(firstname, lastname);
            var expectedMismatch = $"{firstname} Smith";

            //Assert
            Assert.That(result, Is.Not.EqualTo(expectedMismatch));
        }

        [TearDown]
        public void Dispose()
        {
            Debug.WriteLine("After each test");
            sut = null;
        }
    }
}
