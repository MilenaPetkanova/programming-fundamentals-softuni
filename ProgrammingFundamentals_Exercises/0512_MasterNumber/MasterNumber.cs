using System;
using System.Linq;

namespace _12_MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {

            ulong input = ulong.Parse(Console.ReadLine());

            for (ulong num = 1; num <= input; num++)
            {
                //int[] numDigits = num.ToString()
                //        .Select(s => int.Parse(s.ToString()))
                //        .ToArray();

                if (IsPalindrome(num))
                {
                    if (IsSumDivBySeven(num))
                    {
                        if (IsContaingEvenDigit(num))
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }
        }

        static bool IsPalindrome(ulong num)
        {
            bool palindrome = true;
            string numb = num.ToString();
            for (int i = 0; i <= numb.Length / 2; i++)
            {
                if (numb[i] != numb[numb.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }

        private static bool IsSumDivBySeven(ulong num)
        {
            ulong sumDigits = 0;
            while (num != 0)
            {
                sumDigits += num % 10;
                num = num / 10;
            }

            if (sumDigits % 7 == 0)
            {
                return true;
            }
            return false;

       }

        static bool IsContaingEvenDigit(ulong num)
        {
            while (num != 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
            }
            return false;
        }

    }
}