using System;
using System.Linq;

namespace _0611_EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                    .Split(' ').Select(int.Parse).ToArray();

            int bestIndex = 0;
            bool equalSums = false;

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int left = 0; left < i; left++)
                {
                    leftSum += nums[left];
                }
                for (int right = i + 1; right < nums.Length; right++)
                {
                    rightSum += nums[right];
                }
                if (leftSum == rightSum)
                {
                    bestIndex = i;
                    equalSums = true;
                    break;
                }
            }

            if (equalSums == true)
            {
                Console.WriteLine(bestIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
