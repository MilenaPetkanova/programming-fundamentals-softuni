using System;
using System.Collections.Generic;
using System.Linq;

namespace _0704_SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] 
            {',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> inputText = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> isLowerList = new List<string>();
            List<string> isMixedList = new List<string>();
            List<string> isUpperList = new List<string>();

            foreach (string word in inputText)
            {
                bool isLower = IsLowerCase(word);
                bool isUpper = IsUppesCase(word);
                bool isMixed = !isLower && !isUpper;

                if (isLower)
                {
                    isLowerList.Add(word);
                }
                else if (isUpper)
                {
                    isUpperList.Add(word);
                }
                else if (isMixed)
                {
                    isMixedList.Add(word);
                }
            }
            Console.Write("Lower-case: ");
            Console.WriteLine(String.Join(", ", isLowerList));
            Console.Write("Mixed-case: ");
            Console.WriteLine(String.Join(", ", isMixedList));
            Console.Write("Upper-case: ");
            Console.WriteLine(String.Join(", ", isUpperList));
        }

        private static bool IsLowerCase(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if (char.IsUpper(word[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsUppesCase(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if (char.IsLower(word[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
