using System;
using System.Linq;

namespace _0605_RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
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
}
