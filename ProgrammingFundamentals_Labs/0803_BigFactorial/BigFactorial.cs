using System;
using System.Numerics;

class BigFactorial
{
    static void Main()
    {

        int num = int.Parse(Console.ReadLine());

        BigInteger numFactorial = 1;

        for (int i = 1; i <= num; i++)
        {
            numFactorial *= i;
        }

        Console.WriteLine(numFactorial);
    }
}
