using System;

namespace _0402_CircleAreaWithPrecision
{
    class CircleAreaWithPrecision
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine($"{area:F12}");
        }
    }
}
