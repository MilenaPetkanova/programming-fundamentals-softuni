using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class ConvertFromBaseNToBase10
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ')
            .Select(BigInteger.Parse).ToArray();

        var baseN = numbers[0];
        var n = numbers[1];

        string base10 = ConvertBaseNToBase10(baseN, n);

        Console.WriteLine(base10);
    }

    private static string ConvertBaseNToBase10(BigInteger baseN, BigInteger n)
    {
        BigInteger result = 0;
        int index = 0;

        while (true)
        {
            var digit = n % 10;
            result += digit * BigInteger.Pow(baseN, index++);
            n /= 10;
            if (n <= 0)
            {
                break;
            }
        }

        string resultToString = result.ToString();
        return resultToString;
    }
}
