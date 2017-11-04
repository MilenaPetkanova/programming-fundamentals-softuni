using System;
using System.Text.RegularExpressions;

class Regexmon
{
    static void Main()
    {
        string input = Console.ReadLine();

        string didiPattern = @"[^a-zA-Z-]+";
        string bojoPattern = @"[a-zA-Z]+-[a-zA-Z]+";

        while (true)
        {
            var didiMatch = Regex.Match(input, didiPattern);
            if (didiMatch.Success)
            {
                string didimon = didiMatch.Value.ToString();
                Console.WriteLine(didimon);
            }
            else
            {
                return;
            }

            input = input.Remove(0, didiMatch.Index + didiMatch.Length);

            var bojoMatch = Regex.Match(input, bojoPattern);
            if (bojoMatch.Success)
            {
                string bojomon = bojoMatch.Value.ToString();
                Console.WriteLine(bojomon);
            }
            else
            {
                return;
            }

            input = input.Remove(0, bojoMatch.Index + bojoMatch.Length);

        }
    }
}
