using NUnit.Framework;
using System;

namespace NUnitExamples
{
    [Category("Basic Math Tests")]
    [TestFixture]
    class BasicCalculatorTests
    {
        BasicCalculator sut;

        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine($"Executed Before the test");
            sut = new BasicCalculator();
        }

        [Test]
        [TestCase(20, 30)]
        [TestCase(-5, 25)]
        [TestCase(75, 1225)]
        public void ShouldAddTwoNumbers(int num1, int num2)
        {
            ////Arranged: 
            //var sut = new BasicCalculator();
            var expectedResult = num1 + num2;

            //Act
            var result = sut.Add(num1, num2);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(2.5, 3.2)]
        [TestCase(2.15, -3.5)]
        public void ShouldAddTwoDoubles(double number1, double number2)
        {
            var result = sut.Add(number1, number2);
            var expectedResult = number1 + number2;

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]       
        public void ShouldAddTwoDoubles()
        {
            double number1 = 1.1;
            double number2 = 2.2;
            var expectedResult = 3.3;

            var result = sut.Add(number1, number2);
            

            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        [Test]
        public void ShouldAddTwoDoubles_WithPercentTolerance()
        {
            double number1 = 50;
            double number2 = 50;
            var expectedResult = 101;

            var result = sut.Add(number1, number2);

            Assert.That(result, Is.EqualTo(expectedResult).Within(1).Percent);
        }

        [Test]
        [TestCase(20, 30)]
        [TestCase(-5, 25)]
        [TestCase(75, 1225)]
        public void ShouldMultiplyTwoNumbers(int num1, int num2)
        {
            //Arranged: 
            //var sut = new BasicCalculator();
            var expectedResult = num1 * num2;

            //Act
            var result = sut.Multiply(num1, num2);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine($"Executed After the test");
            sut = null;
        }
    }
}
