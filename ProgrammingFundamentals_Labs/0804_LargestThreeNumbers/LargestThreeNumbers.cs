﻿using System;
using System.Linq;

class LargestThreeNumbers
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        var largestNums = nums.OrderByDescending(x => x).Take(3).ToList();

        Console.WriteLine(String.Join(" ", largestNums));
    }
}
