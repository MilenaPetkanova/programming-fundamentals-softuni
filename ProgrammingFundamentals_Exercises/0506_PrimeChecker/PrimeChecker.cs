using System;

namespace _0506_PrimeChecker
{
    class PrimeChecker
    {
        public static object PrimeTool { get; private set; }

        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }
    }
}
