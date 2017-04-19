using NUnit.Framework;

namespace NUnitExamples
{
    [TestFixture]
    [Category("Collections")]
    public class CollectionTests
    {
        SuperMarioDemo sut;
        private const int _defaultHealth = 100;

        [SetUp]
        public void Setup()
        {
            sut = new SuperMarioDemo(_defaultHealth);
        }


        [Test]
        public void ShouldHaveNoDefaultEmptyPower()
        {
            Assert.That(sut.Powers, Is.All.Not.Empty);
        }

        [Test]
        public void ShouldHaveAHighJump()
        {
            //wrong
            //Assert.That(sut.Powers, Is.All.Contain("High JUMP").IgnoreCase);

            Assert.That(sut.Powers, Contains.Item("HIGH Jumper").IgnoreCase);
        }


        [Test]
        public void ShouldHaveTwoPowersStartingWithLetterU()
        {
            //Can be one or more
            //Assert.That(sut.Powers, Has.Some.StartsWith("U").IgnoreCase);

            //All starting with U - fails
            //Assert.That(sut.Powers, Has.All.StartsWith("U").IgnoreCase);

            //exactly two members
            Assert.That(sut.Powers, Has.Exactly(2).StartsWith("U").IgnoreCase);
        }


        [TearDown]
        public void Teardown()
        {
            sut = null;
        }
    }
}
