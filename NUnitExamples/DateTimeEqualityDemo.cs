using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
    public class DateTimeEqualityDemo
    {
        public DateTime GetSpecialDate(bool isSpecial)
        {
            if (isSpecial) return new DateTime(2081, 1, 1, 0, 0, 0, 0); //Specific future date

            throw new ArgumentOutOfRangeException(nameof(isSpecial));
        }
    }
}
