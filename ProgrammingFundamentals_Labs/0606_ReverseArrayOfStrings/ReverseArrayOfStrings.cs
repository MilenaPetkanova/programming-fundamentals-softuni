﻿using System;
using System.Linq;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();

        Array.Reverse(input);

        string output = string.Join(" ", input);
        Console.WriteLine(output);
    }
}
