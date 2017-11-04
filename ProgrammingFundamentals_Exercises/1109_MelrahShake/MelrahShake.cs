using System;
using System.Text.RegularExpressions;

class MelrahShake
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = Console.ReadLine();

        while (Regex.IsMatch(input, Regex.Escape(pattern) + @"(.*)" + Regex.Escape(pattern))
            && input.Length > pattern.Length) 
        {
            Console.WriteLine("Shaked it.");

            var match = Regex.Match(input, Regex.Escape(pattern) + @"(.*)" + Regex.Escape(pattern));

            input = input.Remove(match.Index + match.Length - pattern.Length, pattern.Length);
            input = input.Remove(match.Index, pattern.Length);

            pattern = pattern.Remove(pattern.Length / 2, 1);
            if (pattern.Length <= 0)
            {
                break;
            }

        }

        Console.WriteLine("No shake.");
        Console.WriteLine(input);
    }
}
