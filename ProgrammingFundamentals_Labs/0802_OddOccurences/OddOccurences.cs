using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurences
{
    static void Main()
    {
        var input = Console.ReadLine().ToLower()
            .Split(' ').ToArray();

        var count = new Dictionary<string, int>();

        foreach (var word in input)
        {
            if (count.ContainsKey(word))
            {
                count[word]++;
            }
            else
            {
                count[word] = 1;
            }
        }

        List<string> result = new List<string>();
        foreach (var pair in count)
        {
            if (pair.Value % 2 == 1)
            {
                result.Add(pair.Key);
            }
        }

        Console.WriteLine(String.Join(", ", result));
    }
}
