using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
            .Split(' ').Select(int.Parse).ToArray();

        int maxSequence = 1;
        int currSequence = 1;
        int bestStartPos = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int currPos = i;
            while (i < nums.Length - 1
                && nums[i] == nums[i + 1])
            {
                currSequence++;
                if (currSequence > maxSequence)
                {
                    maxSequence = currSequence;
                    bestStartPos = currPos;
                }
                i++;
            }
            currSequence = 1;
        }

        for (int i = bestStartPos; i < bestStartPos + maxSequence; i++)
        {
            Console.Write("{0} ", nums[i]);
        }
        Console.WriteLine();
    }
}
