using System;

class CountSubstringOccurances
{
    static void Main()
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int occurences = 0;
        int index = -1;

        while (text.IndexOf(pattern, index + 1) != -1)
        {
            occurences++;
            index = text.IndexOf(pattern, index + 1);
        }

        Console.WriteLine(occurences);
    }
}
