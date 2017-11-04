using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        List<int> nums = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        int bestStart = 0;
        int count = 1;
        int maxCount = 1;

        for (int i = 0; i < nums.Count - 1; i++)
        {
            int temp = i;
            while (i < nums.Count - 1
                && nums[i] == nums[i + 1])
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                    bestStart = temp;
                }
                i++;
            }
            count = 1;
        }

        for (int i = bestStart; i < bestStart + maxCount; i++)
        {
            Console.Write("{0} ", nums[i]);
        }
        Console.WriteLine();
    }
}
