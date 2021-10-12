using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;

        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }
    }
}

