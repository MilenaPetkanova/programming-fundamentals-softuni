using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0211_FiveDifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int m = a; m <= b; m++)
                    {
                        for (int n = a; n <= b; n++)
                        {
                            for (int p = a; p <= b; p++)
                            {
                                if (a <= i && i < j && j < m && m < n && n < p && p <= b)
                                {
                                    Console.WriteLine($"{i} {j} {m} {n} {p}");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
