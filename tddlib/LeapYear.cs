using System;

namespace tddlib
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (IsDivisableBy4OnlyExcept100(year))
            {
                return true;
            }
            else
            {
                return IsDivisableBy400(year);
            }
        }

        private bool IsDivisableBy4OnlyExcept100(int year)
        {
            return year % 4 == 0 && year % 100 != 0;
        }

        private bool IsDivisableBy400(int year)
        {
            return year % 400 == 0;
        }
    }
}
