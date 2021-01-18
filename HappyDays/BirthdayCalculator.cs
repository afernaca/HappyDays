using System;

namespace HappyDays
{
    public static class BirthdayCalculator
    {
        public static int CalculateDays(DateTime birthdate)
        {
            var nextBirthdate = new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day);
            var diff = nextBirthdate - DateTime.Now;

            return diff.Days;
        }
    }
}
