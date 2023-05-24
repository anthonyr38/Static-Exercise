using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit) 
        {
            double resultToCelsius = (fahrenheit - 32) / 1.8;
            
            return resultToCelsius;
        }
        public static double CelsiusToFahrenheit(double celsius) 
        {
            double resultToFahrenheit = (celsius * 9) / 5 + 32;

            return resultToFahrenheit;
        }
    }
}
