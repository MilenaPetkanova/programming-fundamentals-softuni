using System;

namespace _0503_EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string inputConverted = input.ToString();
            string lastSymbol = 
                inputConverted.Substring(inputConverted.Length - 1, 1);

            int lastDigit = Convert.ToInt32(lastSymbol);

            Console.WriteLine(GetNameOfLastDigit(lastDigit));
        }

        private static string GetNameOfLastDigit(int lastDigit)
        {
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid";
            }
        }
    }
}
