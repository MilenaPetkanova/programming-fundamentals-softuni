using System;
using System.Linq;

namespace _0504_NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {

            double input = double.Parse(Console.ReadLine());
            PrintReversedDigits(input);
        }

        private static void PrintReversedDigits(double input)
        {
            string reversedString = new string(input.ToString().Reverse().ToArray());
            Console.WriteLine(reversedString);
        }
    }
}
