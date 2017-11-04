using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchNumbers
{
    static void Main()
    {
        var input = Console.ReadLine();
        var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

        var matchedNumbers = Regex.Matches(input, pattern);

        var validPhones = matchedNumbers
            .Cast<Match>()
            .Select(x => x.Value.Trim())
            .ToArray();

        Console.WriteLine(String.Join(" ", validPhones));
    }
}
