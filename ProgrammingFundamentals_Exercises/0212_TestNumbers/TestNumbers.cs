using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0212_TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= sumBoundary)
                    {
                        break;
                    }
                    sum += i * j * 3;
                    counter++;
                }
            }
            if (sum >= sumBoundary)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {sumBoundary}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
