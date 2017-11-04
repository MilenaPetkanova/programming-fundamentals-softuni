using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        List<string> result = new List<string>();

        string input = Console.ReadLine();

        string pattern = @"\s(?!_|\.|\-)(?:[\w\.\-]+)(?<!_|\.|\-)@[a-z]+-?[a-z]+(\.[a-z]+-?[a-z]+)+\b";

        MatchCollection validEmails = Regex.Matches(input, pattern);

        foreach (Match m in validEmails)
        {
            string email = m.ToString().Trim();
            result.Add(email);
        }

        foreach (var email in result)
        {
            Console.WriteLine(email);
        }
    }
}
