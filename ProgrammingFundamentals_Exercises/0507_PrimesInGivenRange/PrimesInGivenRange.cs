using System;
using System.Collections.Generic;

namespace _0507_PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> primeNums = FinddPrimesInRange(startNum, endNum);
            PrintIntegerList(primeNums);
        }

        private static void PrintIntegerList(List<int> primeNums)
        {
            for (int i = 0; i < primeNums.Count; i++)
            {
                if (i != primeNums.Count - 1)
                {
                    Console.Write("{0}, ", primeNums[i]);
                }
                else
                {
                    Console.Write("{0}", primeNums[i]);
                }
            }
            Console.WriteLine();
        }

        static List<int> FinddPrimesInRange(int startNum, int endNum)
        {
            List<int> listRange = new List<int>();
            for (int num = startNum; num <= endNum; num++)
            {
                if (IsPrime(num) == true)
                {
                    listRange.Add(num);
                }
            }
            return listRange;
        }

        private static bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}
