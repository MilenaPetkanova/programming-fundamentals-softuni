using System;

class RandomizeWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] textArgs = text.Trim()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        Random rnd = new Random();

        for (int i = 0; i < textArgs.Length; i++)
        {
            int rndIndex = rnd.Next(i, textArgs.Length);
            string temp = textArgs[i];
            textArgs[i] = textArgs[rndIndex];
            textArgs[rndIndex] = temp;

            Console.WriteLine(textArgs[i]);
        }

        
    }
}
