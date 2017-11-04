using System;
using System.Linq;
using System.IO;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        string inputTest1 = File.ReadAllText("inputTest1.txt");
        string inputTest2 = File.ReadAllText("inputTest2.txt");
        string inputTest3 = File.ReadAllText("inputTest3.txt");

        string[] allinputTests = { inputTest1, inputTest2, inputTest3 };

        for (int test = 0; test < allinputTests.Length; test++)
        {
            int[] nums = allinputTests[test]
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
            File.WriteAllText($"outputTest{test + 1}.txt", maxFrequ.ToString());
            Console.WriteLine(maxFrequ);
        }
    }
}
