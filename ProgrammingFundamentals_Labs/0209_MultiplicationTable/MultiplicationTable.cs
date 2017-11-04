using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209_MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int product = 0;

            for (int i = 1; i <= 10; i++)
            {
                product = input * i;
                Console.WriteLine($"{input} X {i} = {product}");
            }
        }
    }
}
