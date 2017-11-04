using System;
using System.Collections.Generic;
using System.Linq;

class Numbers
{
    static void Main()
    {
        var nums = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();
        
        double average = nums.Average();

        List<int> greater = new List<int>();

        foreach (var num in nums)
        {
            if (num > average)
            {
                greater.Add(num);
            }
        }

        greater.Sort();
        greater.Reverse();

        List<int> topFive = new List<int>(greater);

        if (greater.Count >= 5)
        {
            topFive = greater.Take(5).ToList();
        }


        if (topFive.Count > 0)
        {
            Console.WriteLine(string.Join(" ", topFive));
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
