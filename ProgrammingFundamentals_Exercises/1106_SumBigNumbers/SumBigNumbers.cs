using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SumBigNumbers
{
    static void Main()
    {
        string firstNum = Console.ReadLine().TrimStart('0');
        string secondNum = Console.ReadLine().TrimStart('0');

        if (firstNum.Length > secondNum.Length)
        {
            secondNum = secondNum.PadLeft(firstNum.Length, '0');
        }
        if (secondNum.Length > firstNum.Length)
        {
            firstNum = firstNum.PadLeft(secondNum.Length, '0');
        }

        var remainder = 0;

        var builder = new StringBuilder();

        for (int i = firstNum.Length - 1; i >= 0; i--)
        {
            int sum = remainder
                + int.Parse(firstNum.ElementAt(i).ToString())
                + int.Parse(secondNum.ElementAt(i).ToString());

            remainder = sum / 10;
            var digit = sum % 10;
            builder.Insert(0, digit);
            
            if (i == 0 && remainder != 0)
            {
                builder.Insert(0, remainder);
            }
        }

        string result = builder.ToString();
        Console.WriteLine(result);
    }
}
