using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    [TestFixture]
    [Category("Mario Tests")]
    public class SuperMarioTests
    {
        SuperMarioDemo sut;
        private int _defaultHealth = 100;

        [SetUp]
        public void Setup()
        {
            sut = new SuperMarioDemo(health: _defaultHealth);
        }

        [Test]
        public void ShouldIncreaseHealthAfterTakingReset()
        {
            sut.TakeRest();

            Assert.That(sut.Health, Is.GreaterThan(_defaultHealth));
        }

        [Test]
        public void ShouldIncreaseHealthInExpectedRangeAfterTakingRest()
        {
            sut.TakeRest();

            Assert.That(sut.Health, Is.InRange(_defaultHealth + 1, 200));//inclusive
        }


        [TearDown]
        public void Teardown()
        {
            sut = null;
        }
    }
}
