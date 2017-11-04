using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        string[] words = File.ReadAllText("words.txt").Split(' ');
        string[] text = File.ReadAllText("text.txt")
            .ToLower()
            .Split(new char[] { ' ', ',', '-', '?', '!', '.' },
            StringSplitOptions.RemoveEmptyEntries);

        var repeatedWords = new Dictionary<string, int>();
        for (int i = 0; i < words.Length; i++)
        {
            foreach (var word in text)
            {
                if (word == words[i])
                {
                    if (!repeatedWords.ContainsKey(word))
                    {
                        repeatedWords.Add(word, 0);
                    }
                    repeatedWords[word]++;
                }
            }
        }


        //string[] outputWords = null;
        foreach (var item in repeatedWords.OrderByDescending(x=> x.Value))
        {
            File.AppendAllText("output.txt", 
                $"{item.Key} - {item.Value}" + Environment.NewLine);
            
        }

    }
}
