using System;
using System.IO;
using System.Linq;

class EqualSums
{
    static void Main(string[] args)
    {
        string inputTest1 = File.ReadAllText(@"test files\inputTest1.txt");
        string inputTest2 = File.ReadAllText(@"test files\inputTest2.txt");
        string inputTest3 = File.ReadAllText(@"test files\inputTest3.txt");
        string inputTest4 = File.ReadAllText(@"test files\inputTest4.txt");
        string inputTest5 = File.ReadAllText(@"test files\inputTest5.txt");

        string[] allinputTests = { inputTest1, inputTest2, inputTest3, inputTest4, inputTest5 };

        for (int test = 0; test < allinputTests.Length; test++)
        {
            int[] nums = allinputTests[test]
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

            string output = null;
            if (equalSums == true)
            {
                output = bestIndex.ToString();
            }
            else
            {
                output = "no";
            }
            File.Delete($@"test files\outputTest{test + 1}.txt");
            File.AppendAllText($@"test files\outputTest{test + 1}.txt", output);

        }

    }
}
