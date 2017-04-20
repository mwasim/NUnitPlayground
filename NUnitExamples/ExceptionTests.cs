using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    [TestFixture]
    [Category("Exceptions")]
    public class ExceptionTests
    {
        [Test]
        public void ShouldNotAllowDividingByZero()
        {
            var calc = new BasicCalculator();

            //first parameter = code we expect to throw the exception
            //setcond parameter = exception which is thrown
            Assert.That(() => calc.Divide(number: 100, divideBy: 0), Throws.Exception);

            //The following does not work
            //Action action = () => { calc.Divide(number: 100, divideBy: 0); };
            //Assert.That(action, Throws.Exception);

            //Does not work
            //Action action = () => calc.Divide(number: 100, divideBy: 0); 
            //Assert.That(action, Throws.Exception);

            //works fine
            TestDelegate dlg = () => calc.Divide(number: 100, divideBy: 0);
            Assert.That(dlg, Throws.Exception);

            //Explicit exception type
            Assert.That(() => calc.Divide(number: 100, divideBy: 0), Throws.TypeOf<DivideByZeroException>());
        }


        [Test]
        public void ShouldErrorWhenNumberIsTooBig()
        {
            var calc = new BasicCalculator();

            Assert.That(() => calc.Divide(number: 101, divideBy: 2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ShouldErrorWhenNumberIsTooBigAndCheckDivideByParameter()
        {
            var calc = new BasicCalculator();

            Assert.That(() => calc.Divide(number: 101, divideBy: 2),
                Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "divideBy"));
        }
    }
}
