using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        var firstK = numbers.Take(k).Reverse();
        var lastK = numbers.Skip(3 * k).Take(k).Reverse();

        var firstLine = firstK.Concat(lastK).ToArray();

        var secondLine = numbers.Skip(k).Take(2 * k).ToArray();

        var sum = firstLine.Select((x, index) => x + secondLine[index]).ToArray();

        Console.WriteLine(String.Join(" ", sum));
    }
}
