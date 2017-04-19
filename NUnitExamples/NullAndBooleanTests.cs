using NUnit.Framework;

namespace NUnitExamples
{
    [TestFixture]
    [Category("Nulls and Booleans")]
    public class NullAndBooleanTests
    {
        SuperMarioDemo sut;
        private int _defaultHealth = 100;

        [SetUp]
        public void Setup()
        {
            sut = new SuperMarioDemo(health: _defaultHealth);
        }

        [Test]
        public void ShouldHaveAName()
        {
            var name = sut.Name;

            Assert.That(name, Is.Not.Null);
            Assert.That(name, Is.Not.Empty);
        }

        [Test]
        public void ShouldBeAlive()
        {
            var result = sut.IsAlive;

            Assert.That(result, Is.True);
        }

        public void Teardown()
        {
            sut = null;
        }
    }
}
