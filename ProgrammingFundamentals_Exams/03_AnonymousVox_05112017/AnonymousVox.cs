using System;
using System.Text.RegularExpressions;

class AnonymousVox
{
    static void Main()
    {
        string encodedText = Console.ReadLine();
        string values = Console.ReadLine();

        var textMatches = Regex.Matches(encodedText, @"([a-zA-Z]+)(.+)?\1");
        int placeholdersCount = textMatches.Count;
        var valuesMatches = Regex.Matches(values, @"{(.*?)}");
        int valueCount = valuesMatches.Count;

        int longest = Math.Max(placeholdersCount, valueCount);

        if (longest == valueCount)
        {
            for (int i = 0; i < placeholdersCount; i++)
            {
                string placeholder = textMatches[i].Groups[2].ToString();
                string replacement = valuesMatches[i].Groups[1].ToString();

                encodedText = ReplaceFirst(encodedText, placeholder, replacement);
            }
        }
        else
        {
            for (int i = 0; i < valueCount; i++)
            {
                string placeholder = textMatches[i].Groups[2].ToString();
                string replacement = valuesMatches[i].Groups[1].ToString();

                encodedText = encodedText.Replace(placeholder, replacement);
            }
        }

        Console.WriteLine($"{encodedText}");
    }

    private static string ReplaceFirst(string encodedText, string oldValue, string newValue)
    {
        string substringWithOldValue = encodedText.Substring(0, encodedText.IndexOf(oldValue) + oldValue.Length);
        string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

        return substringWithNewValue + encodedText.Substring(substringWithOldValue.Length);
    }
}
