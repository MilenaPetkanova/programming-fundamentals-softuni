using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class ConvertFromBase10toBaseN
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ')
            .Select(BigInteger.Parse).ToArray();

        var n = numbers[0];
        var base10 = numbers[1];

        string baseN = ConvertBase10ToBaseN(base10, n);

        Console.WriteLine(baseN);
    }

    private static string ConvertBase10ToBaseN(BigInteger base10, BigInteger n)
    {
        var builder = new StringBuilder();

        while (true)
        {
            var result = base10 % n;
            builder.Insert(0, result);
            base10 /= n;
            if (base10 <= 0)
            {
                break;
            }
        }

        string resultToString = builder.ToString();
        return resultToString;
    }
}
