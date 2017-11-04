using System;

class TextFilter
{
    static void Main()
    {
        string bannedWords = Console.ReadLine();

        string text = Console.ReadLine();

        string[] banned = bannedWords.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //Same result:
        //string[] banned = Regex.Split(bannedWords, ", ");

        foreach (string word in banned)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}
