using System;

namespace _0505_TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double tempFarenheit = double.Parse(Console.ReadLine());
            double tempCelsius = FarenheitToCelsius(tempFarenheit);
            Console.WriteLine("{0:F2}", tempCelsius);    
        }

        static double FarenheitToCelsius(double tempFarenheit)
        {
            double tempCelsius = (tempFarenheit - 32) * 5 / 9;
            return tempCelsius;
        }
    }
}
