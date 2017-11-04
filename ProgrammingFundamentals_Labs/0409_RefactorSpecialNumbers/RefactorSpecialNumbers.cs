using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= inputNum; i++)
        {
            bool isMagic = false;
            int sum = 0;
            int digits = i;

            while (i > 0)
            {
                sum += i % 10;
                i = i / 10;
            }

            isMagic = (sum == 5 || sum == 7 || sum == 11);

            Console.WriteLine($"{digits} -> {isMagic}");

            sum = 0;
            i = digits;
        }
    }
}
