using NUnit.Framework;
using System.Collections.Generic;

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

            //fails
            //Assert.That(sut.Powers, Contains.Item("Jumper").IgnoreCase);
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

        [Test]
        public void ShouldHaveAtLeastOneKindOfJumperPower()
        {
            //Assert.That(sut.Powers, Has.Some.Contain("JUMPER").IgnoreCase);
            Assert.That(sut.Powers, Has.Some.Contains("JUMPER").IgnoreCase);
        }

        [Test]
        public void ShouldHaveEachPowerUnique()
        {

            //Assert.That(sut.Powers, Is.All.Unique);//fails as Unique is applied to a collection and not each item

            Assert.That(sut.Powers, Is.Unique);
        }

        [Test]
        public void ShouldNotHaveASpecificItem()
        {
            //Assert.That(sut.Powers, Has.None.Contains("Sky Diver")); //passes

            Assert.That(sut.Powers, Has.None.EqualTo("Sky Diver").IgnoreCase);
        }

        [Test]
        public void ShouldHaveAllTheExpectedItems()
        {
            var expectedPowers = new List<string> {
                "Unlimited Lives",
                "Untouchable",
                "High Jumper",
                "Long Jumper",
                //""
            };

            Assert.That(sut.Powers, Is.EquivalentTo(expectedPowers));
        }

        [Test]
        public void ShouldHaveAllPowersInAlphabeticalOrder()
        {
            Assert.That(sut.Powers, Is.Ordered);
        }

        [TearDown]
        public void Teardown()
        {
            sut = null;
        }
    }
}
