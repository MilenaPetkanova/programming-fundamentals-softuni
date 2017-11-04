using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MatchHexadecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"\b(0x)?[0-9A-F]+\b";

        var matches = Regex.Matches(input, pattern)
            .Cast<Match>().Select(x => x.Value).ToArray();

        Console.WriteLine(string.Join(" ", matches));
    }
}
