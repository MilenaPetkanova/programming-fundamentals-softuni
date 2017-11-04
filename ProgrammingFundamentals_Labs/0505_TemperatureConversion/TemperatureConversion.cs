using System;

class TemperatureConversion
{
    static void Main()
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
