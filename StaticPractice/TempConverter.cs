using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPractice
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheitTemp)
        {
            double celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
            return celsiusTemp;
        }
        public static double CelsiusToFahrenheit(double celsiusTemp)
        {
            double farenheitTemp = (celsiusTemp * 9) / 5 + 32;
            return farenheitTemp;
        }
    }
}
