using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main()
    {
        List<string> tokens = Console.ReadLine()
            .Split('|').ToList();

        List<int> results = new List<int>();

        for (int i = tokens.Count - 1; i >= 0; i--)
        {
            int[] elements =
                tokens[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            results.AddRange(elements);
        }

        Console.WriteLine(string.Join(" ", results));
    }
}
