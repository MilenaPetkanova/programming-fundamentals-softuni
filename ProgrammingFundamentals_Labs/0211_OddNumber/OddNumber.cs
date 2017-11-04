using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0211_OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            while (input % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                input = int.Parse(Console.ReadLine());
            }

            if (input < 0)
            {
                input = Math.Abs(input);
            }
            Console.WriteLine($"The number is: {input}");

        }
    }
}
