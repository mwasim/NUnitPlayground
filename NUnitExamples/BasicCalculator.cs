using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    public class BasicCalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number, int divideBy)
        {
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(divideBy));
            }

            return number / divideBy;
        }
    }
}
