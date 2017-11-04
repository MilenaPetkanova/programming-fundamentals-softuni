using System;
using System.Linq;

class ExtractMiddleElements
{
    static void Main()
    {
        int[] nums = Console.ReadLine().
                Split(' ').Select(int.Parse).ToArray();

        int numsLength = nums.Length;

        if (numsLength == 1)
        {
            Console.Write("{ ");
            Console.Write(nums[0]);
            Console.Write(" }");
            Console.WriteLine();
        }
        else if (numsLength % 2 == 0)
        {
            int[] middleNumbers = new int[2];
            middleNumbers[0] = nums[numsLength / 2 - 1];
            middleNumbers[1] = nums[numsLength / 2];
            Console.Write("{ ");
            Console.Write(string.Join(", ", middleNumbers));
            Console.Write(" }");
            Console.WriteLine();
        }
        else if (numsLength % 2 == 1)
        {
            int[] middleNumbers = new int[3];
            middleNumbers[0] = nums[numsLength / 2 - 1];
            middleNumbers[1] = nums[numsLength / 2];
            middleNumbers[2] = nums[numsLength / 2 + 1];
            Console.Write("{ ");
            Console.Write(string.Join(", ", middleNumbers));
            Console.Write(" }");
            Console.WriteLine();
        }
    }
}
