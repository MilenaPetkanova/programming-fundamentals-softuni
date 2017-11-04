using System;
using System.Collections.Generic;

class DebitCardNumber
{
    static void Main()
    {
        List<string> result = new List<string>();

        for (int i = 0; i < 4; i++)
        {
            int n = int.Parse(Console.ReadLine());

            result.Add(n.ToString("D4"));
        }

        Console.WriteLine(String.Join(" ", result));
    }
}
