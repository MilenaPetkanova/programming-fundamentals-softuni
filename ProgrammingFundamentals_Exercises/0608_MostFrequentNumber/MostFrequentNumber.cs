using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main(string[] args)
    {

        int[] nums = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();

        int currNum = 0;
        int numFrqu = 0;
        int bestFrequ = 0;
        int maxFrequ = 0;

        for (int num = 0; num < nums.Length; num++)
        {
            currNum = nums[num];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == currNum)
                {
                    numFrqu++;
                }
            }
            if (numFrqu > bestFrequ)
            {
                bestFrequ = numFrqu;
                maxFrequ = currNum;
            }
            numFrqu = 0;
        }
        Console.WriteLine(maxFrequ);
    }
}
