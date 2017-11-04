using System;

namespace _0604_SlieveOfEratosthenes
{
    class SlieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] primeNums = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                primeNums[i] = i;
            }

            bool[] primeBools = new bool[n + 1];
            for (int i = 0; i < primeBools.Length; i++)
            {
                primeBools[i] = true;
            }
            primeBools[0] = false;
            primeBools[1] = false;

            for (int i = 2; i <= n; i++)
            {
                if (primeBools[i] == true)
                {
                    Console.Write("{0} ", primeNums[i]);
                    for (int j = i; j <= n; j+=i)
                    {
                        primeBools[j] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}