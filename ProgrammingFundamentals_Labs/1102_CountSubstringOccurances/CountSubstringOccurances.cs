using System;
using System.Collections.Generic;
using System.Text;

class CountSubstringOccurances
{
    static void Main()
    {

        string text = Console.ReadLine().ToLower();
        string search = Console.ReadLine().ToLower();

        int substrCounter = 0;
        int match = 0;
        for (int i = 0; i < text.Length; i++)
        {
            text = text.Substring(match);
            match = text.IndexOf(search, match);
            if (match != -1)
            {
                substrCounter++;
            }
            Console.WriteLine(substrCounter);

            //int i = 0;
            //while ((i = text.IndexOf(search, i)) != -1)
            //{
            //    // Print out the substring.
            //    Console.WriteLine(text.Substring(i));

            //    // Increment the index.
            //    text = text.Substring(i);
            //    substrCounter++;
            //    //i += 1;
            //}
            //Console.WriteLine(substrCounter);
        }
    }
}
