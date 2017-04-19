using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    [TestFixture]
    public class RandomTests
    {
        [Test]
        public void ShouldBeWithin5PercentTolerance()
        {
            var result = 102;

            Assert.That(result, Is.EqualTo(101).Within(5).Percent);
        }
    }
}
