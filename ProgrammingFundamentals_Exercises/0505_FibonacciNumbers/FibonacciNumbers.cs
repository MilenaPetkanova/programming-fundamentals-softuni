using System;

namespace _0505_FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int fibbonacciNumber = Fibb(n);
            Console.WriteLine(fibbonacciNumber);
        }

        private static int Fibb(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                int fibbMinusOne = 1;
                int fibbMinusTwo = 1;
                int fibbNumber = 1;
                for (int i = 2; i <= n; i++)
                {
                    fibbNumber = fibbMinusOne + fibbMinusTwo;
                    fibbMinusOne = fibbMinusTwo;
                    fibbMinusTwo = fibbNumber;
                }
                return fibbNumber;

            }
        }
    }
}
