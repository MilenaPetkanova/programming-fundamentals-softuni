using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";

        var phoneMatches = Regex.Matches(input, pattern);

        var validPhones = phoneMatches
            .Cast<Match>()
            .Select(x => x.Value.Trim())
            .ToArray();

        Console.WriteLine(String.Join(", ", validPhones));
    }
}
