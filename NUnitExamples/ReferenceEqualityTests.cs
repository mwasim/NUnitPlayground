using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    [TestFixture]
    [Category("Reference Eqaulity")]
    public class ReferenceEqualityTests
    {
        SuperMarioDemo sut;
        private const int _defaultHealth = 100;

        [SetUp]
        public void Setup()
        {
            sut = new SuperMarioDemo(_defaultHealth);
        }

        [Test]
        public void CheckReferencesEquality()
        {
            var sut2 = new SuperMarioDemo(_defaultHealth);

            var sutCopy = sut;

            Assert.That(sut, Is.Not.SameAs(sut2));
            Assert.That(sut, Is.SameAs(sutCopy));
        }

        [TearDown]
        public void Teardown()
        {
            sut = null;
        }
    }
}
