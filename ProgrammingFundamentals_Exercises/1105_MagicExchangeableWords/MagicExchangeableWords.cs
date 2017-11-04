using System;
using System.Linq;

class MagicExchangeableWords
{
    static void Main()
    {
        string[] args = Console.ReadLine().Split(' ').ToArray();
        string firstWord = args[0];
        string secondWord = args[1];

        bool isExchangeable = IsWordExchangeable(firstWord, secondWord);
        Console.WriteLine(isExchangeable ? "true" : "false");
    }

    private static bool IsWordExchangeable(string firstWord, string secondWord)
    {
        firstWord = new string(firstWord.Distinct().ToArray());
        secondWord = new string(secondWord.Distinct().ToArray());

        return (firstWord.Length == secondWord.Length);
    }
}
