using System;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().
                Split(' ').Select(double.Parse).ToArray();

        foreach (var item in numbers)
        {
            int rounded = (int)Math.Round(item, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine("{0} => {1}", item, rounded);
        }
    }
}
