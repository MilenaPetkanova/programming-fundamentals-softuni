using System;
using System.Linq;

namespace _0602_RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine()
                    .Split(' ').Select(int.Parse).ToArray();
            int nRotates = int.Parse(Console.ReadLine());

            int[] rotated = new int[nums.Length];
            int[] sum = new int[nums.Length];

            for (int r = 1; r <= nRotates; r++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int newPositionedI = (i + r) % nums.Length;
                    rotated[newPositionedI] = nums[i];
                    sum[newPositionedI] += rotated[newPositionedI];
                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
