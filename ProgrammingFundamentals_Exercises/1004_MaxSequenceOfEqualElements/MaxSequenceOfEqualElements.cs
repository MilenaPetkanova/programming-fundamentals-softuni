using System;
using System.IO;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        string inputTest1 = File.ReadAllText(@"test files\inputTest1.txt");
        string inputTest2 = File.ReadAllText(@"test files\inputTest2.txt");
        string inputTest3 = File.ReadAllText(@"test files\inputTest3.txt");

        string[] allinputTests = { inputTest1, inputTest2, inputTest3 };

        for (int test = 0; test < allinputTests.Length; test++)
        {
            int[] nums = allinputTests[test]
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

            string output = null;
            for (int i = bestStartPos; i < bestStartPos + maxSequence; i++)
            {
                File.Delete($@"test files\outputTest{test + 1}.txt");
                File.AppendAllText($@"test files\outputTest{test + 1}.txt", 
                    nums[i].ToString() + " ");
            }
        }
    }
}
