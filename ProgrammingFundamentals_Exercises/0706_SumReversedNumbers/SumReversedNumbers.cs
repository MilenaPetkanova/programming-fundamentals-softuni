using System;
using System.Collections.Generic;
using System.Linq;

namespace _0706_SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine()
                .Split(' ').ToList();
            
            long result = 0;

            foreach (string element in input)
            {
                string reversed = ReverseString(element);
                int reversedInt = Convert.ToInt32(reversed);
                result += reversedInt;
            }

            Console.WriteLine(result);

        }

        public static string ReverseString(string element)
        {
            char[] arr = element.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
