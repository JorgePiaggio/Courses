using System;
using System.Collections.Generic;
using System.Text;

namespace Accenture.Academy.IntroC.Clase2.Utils
{
    public static class DateTimeExtension
    {
        public static int GetAgeFromBirthDate(this DateTime self)  // con param ´this´ es un metodo de extension
        {
            int edad = DateTime.Today.Year - self.Year;
            if (DateTime.Today.DayOfYear < self.DayOfYear)
            {
                edad--;
            }
            return edad;
        }
    }
}
