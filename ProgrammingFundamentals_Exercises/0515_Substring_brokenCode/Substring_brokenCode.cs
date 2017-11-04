using System;

namespace _0515_Substring_brokenCode
{
    class Substring_brokenCode
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            char search = (char)112;
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;
                    if (jump == 0)
                    {
                        Console.WriteLine(text[i]);
                        continue;
                    }
                    int lastIndex = i + jump + 1;
                    int textLength = text.Length;

                    if (lastIndex >= textLength)
                    {
                        jump = textLength - i - 1;
                    }

                    string matchedString = text.Substring(i, jump + 1);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
