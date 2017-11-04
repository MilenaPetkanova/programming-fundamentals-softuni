using System;

class MilesToKilometers
{
    static void Main(string[] args)
    {
        var miles = double.Parse(Console.ReadLine());

        var kilometers = 1.60934 * miles;

        Console.WriteLine("{0:f2}", kilometers);
    }
}
