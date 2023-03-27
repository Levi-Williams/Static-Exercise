using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelcius(double x)
        {
            return (x - 32) * (5 / 9);
        }

        public static double CelciusToFarenheit(double x)
        {
            return (x * (5 / 9)) + 32;
        }
    }
}
