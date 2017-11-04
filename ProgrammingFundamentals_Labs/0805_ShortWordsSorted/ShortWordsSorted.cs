using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        char[] separators = new char[]
        { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

        string[] words = Console.ReadLine().ToLower()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var result = words
            .Distinct()
            .Where(x => x.Length < 5)
            .OrderBy(x => x)
            .ToArray();

        Console.WriteLine(String.Join(", ", result));
    }
}
