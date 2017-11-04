using System;
using System.Linq;

namespace _0609_ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().
                    Split(' ').Select(int.Parse).ToArray();

            int numsLenght = nums.Length;
            
            if (numsLenght == 1)
            {
                Console.Write("{ ");
                Console.Write(nums[0]);
                Console.Write(" }");
                Console.WriteLine();
            }
            else if (numsLenght % 2 == 0)
            {
                int[] middleNumbers = new int[2];
                middleNumbers[0] = nums[numsLenght / 2 - 1];
                middleNumbers[1] = nums[numsLenght / 2];
                Console.Write("{ ");
                Console.Write(string.Join(", ", middleNumbers));
                Console.Write(" }");
                Console.WriteLine();
            }
            else if (numsLenght % 2 == 1)
            {
                int[] middleNumbers = new int[3];
                middleNumbers[0] = nums[numsLenght / 2 - 1];
                middleNumbers[1] = nums[numsLenght / 2];
                middleNumbers[2] = nums[numsLenght / 2 + 1];
                Console.Write("{ ");
                Console.Write(string.Join(", ", middleNumbers));
                Console.Write(" }");
                Console.WriteLine();
            }
        }
    }
}
