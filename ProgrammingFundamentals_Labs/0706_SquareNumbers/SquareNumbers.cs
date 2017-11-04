using System;
using System.Collections.Generic;
using System.Linq;

namespace _0706_SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
                {
                    result.Add(nums[i]);
                }
            }
            result.Sort();
            result.Reverse();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
