using System;
using System.Linq;

namespace _0608_CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().
                        Split(' ').Select(int.Parse).ToArray();
            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
