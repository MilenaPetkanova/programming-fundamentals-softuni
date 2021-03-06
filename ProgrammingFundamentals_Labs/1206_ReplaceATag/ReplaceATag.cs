﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        List<string> result = new List<string>();

        string text = Console.ReadLine();

        while (text != "end")
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(text, pattern, replacement);
            result.Add(replaced);

            text = Console.ReadLine();
        }

        foreach (var row in result)
        {
            Console.WriteLine($"{row}");
        }
    }
}