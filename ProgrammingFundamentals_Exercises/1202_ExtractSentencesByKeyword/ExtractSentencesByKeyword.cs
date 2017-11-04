using System;
using System.Text.RegularExpressions;

class ExtractSentencesByKeyword
{
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentences = Regex.Split(text, @"[\.!\?]");

        foreach (var sentence in sentences)
        {
            var words = Regex.Split(sentence, @"\W+");
            foreach (var word in words)
            {
                if (Regex.IsMatch(word, @"\b" + keyWord + @"\b"))
                {
                    Console.WriteLine(sentence.Trim());
                    break;
                }
            }
        }

    }
}
