using System;
using System.IO;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        string inputTest1 = File.ReadAllText("test files\\inputTest1.txt");
        string inputTest2 = File.ReadAllText("test files\\inputTest2.txt");

        string[] allinputTests = { inputTest1, inputTest2 };

        for (int test = 0; test < allinputTests.Length; test++)
        {
            string input = allinputTests[test];
            char[] letters = input.ToCharArray();
            string[] output = new string[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                char letter = letters[i];
                int AscciValue = letter;
                int indexLetter = letter - 97;

                output[i] = $"{letter} -> {indexLetter}" + Environment.NewLine;
            }

            File.Delete($"test files\\outputTest{test + 1}.txt");
            foreach (var line in output)
            {
                File.AppendAllText($"test files\\outputTest{test + 1}.txt", line);
            }
        }
    }
}
