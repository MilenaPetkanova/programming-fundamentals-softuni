using System;
using System.Numerics;

namespace _0513_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {

            BigInteger input = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(input));
        }

        private static BigInteger GetFactorial(BigInteger input)
        {
            BigInteger result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
