using System;

class SpecialNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            bool isMagic = false;
            int sumOfDigits = 0;
            int digits = i;

            while (i > 0)
            {
                sumOfDigits += i % 10;
                i /= 10;
            }

            if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
            {
                isMagic = true;
            }

            Console.WriteLine($"{digits} -> {isMagic}");

            sumOfDigits = 0;
            i = digits;
        }
    }
}
