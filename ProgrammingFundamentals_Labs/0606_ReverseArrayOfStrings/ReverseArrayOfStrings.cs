using System;
using System.Linq;

namespace _0606_ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();

            Array.Reverse(input);

            string output = string.Join(" ", input);
            Console.WriteLine(output);
        }
    }
}
