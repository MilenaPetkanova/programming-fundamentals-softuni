using System;
using System.Numerics;

namespace _0514_FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {

            BigInteger input = BigInteger.Parse(Console.ReadLine());
            //int trailingZeroes = GetFactorial(input);
            Console.WriteLine(TrailingZeroes(GetFactorial(input)));
        }

        private static BigInteger TrailingZeroes(BigInteger factorial)
        {
            BigInteger zeroCounter = 0;

            while (factorial > 0 && factorial % 10 == 0)
            {
                factorial /= 10;
                zeroCounter++;
            }
            return zeroCounter;
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
