using System;
using System.Text.RegularExpressions;

class MatchingFullName
{
    public static void Main()
    {
        string input = Console.ReadLine();

        string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.Write("{0} ", m.Value);
        }
        Console.WriteLine();
    }
}