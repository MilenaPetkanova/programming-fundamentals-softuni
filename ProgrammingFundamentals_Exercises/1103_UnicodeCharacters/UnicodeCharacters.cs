using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        var builder = new StringBuilder();
        foreach (var ch in input)
        {
            string unicodeChar = GetEscapeSequence(ch);
            builder.Append(unicodeChar);
        }
        string output = builder.ToString();
        Console.WriteLine(output);
    }

    static string GetEscapeSequence(char c)
    {
        return "\\u" + ((int)c).ToString("x4");
    }
}
