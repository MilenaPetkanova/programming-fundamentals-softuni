using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0213_GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int nMagical = int.Parse(Console.ReadLine());

            bool isMagic = false;
            int combinations = 0;

            for (int i = n2; i >= n1; i--)
            {
                for (int j = n2; j >= n1; j--)
                {
                    combinations++;
                    if (i + j == nMagical)
                    {
                        n1 = i;
                        n2 = j;
                        isMagic = true;
                        break;
                    }
                }
            }
            if (isMagic == true)
            {
                Console.WriteLine($"Number found! {n1} + {n2} = {nMagical}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {nMagical}");
            }
        }
    }
}
