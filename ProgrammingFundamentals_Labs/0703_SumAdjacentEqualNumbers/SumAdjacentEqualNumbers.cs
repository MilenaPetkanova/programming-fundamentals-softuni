using System;
using System.Collections.Generic;
using System.Linq;

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> nums = Console.ReadLine()
            .Split(' ').Select(double.Parse).ToList();

        for (int i = 1; i < nums.Count; i++)
        {
            while (i >= 1 && nums[i] == nums[i - 1])
            {
                nums[i - 1] = nums[i - 1] + nums[i];
                nums.RemoveAt(i);
                i--;
            }
        }

        Console.WriteLine(String.Join(" ", nums));
    }
}
