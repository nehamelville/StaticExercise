using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FahrenheitToCelsius Converter\n-----------------------------\n");
            Console.Write("Please enter temperature in Fahrenheit :");
            double fahrenheitTemp = double.Parse(Console.ReadLine());
            double celsius=TempConverter.FahrenheitToCelsius(fahrenheitTemp);
            Console.WriteLine($"\nFahrenheitToCelsius: {celsius}C");

            Console.WriteLine("\nCelsiusToFahrenheit Converter\n-----------------------------\n");
            Console.Write("Please enter temperature in Celsius :");
            double celciusTemp = double.Parse(Console.ReadLine());
            double fahrenheit = TempConverter.CelsiusToFahrenheit(celciusTemp);
            Console.WriteLine($"\nFahrenheitToCelsius: {fahrenheit}F");


        }
    }
}
