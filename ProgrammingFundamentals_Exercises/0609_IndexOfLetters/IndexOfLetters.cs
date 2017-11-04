using System;

namespace _0609_IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();

            
            for (int i = 0; i < letters.Length; i++)
            {
                char letter = letters[i];
                int AscciValue = letter;
                int indexLetter = letter - 97;
                Console.WriteLine("{0} -> {1}", letter, indexLetter);
            }
        }
    }
}
