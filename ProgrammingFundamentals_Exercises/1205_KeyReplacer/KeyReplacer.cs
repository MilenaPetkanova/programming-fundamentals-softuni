using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class KeyReplacer
{
    static void Main()
    {
        List<string> result = new List<string>();

        string key = Console.ReadLine();
        string text = Console.ReadLine();

        var keyTokens = Regex.Match(key, @"([a-zA-Z]+)[\|\<\\](.*?)[\|\<\\]([a-zA-Z]+)");

        string startKey = keyTokens.Groups[1].ToString();
        string endKey = keyTokens.Groups[3].ToString();
        string wholeKey = startKey + @"(.*?)" + endKey;

        var matches = Regex.Matches(text, wholeKey);

        if (matches.Count != 0)
        {
            foreach (Match m in matches)
            {
                result.Add(m.Groups[1].ToString());
            }
        }
        else
        {
            Console.WriteLine("Empty result");
        }

        Console.WriteLine(String.Join("", result));

    }
}
