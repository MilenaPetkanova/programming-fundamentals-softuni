using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0210_MultiplicationTable._2._0
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 0;

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    product = input * i;
                    Console.WriteLine($"{input} X {i} = {product}");
                }
            }
            else
            {
                product = input * multiplier;
                Console.WriteLine($"{input} X {multiplier} = {product}");
            }
        }
    }
}
