using System;
using System.Linq;

class TripleSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

        bool tripleSums = false;

        for (int a = 0; a < nums.Length; a++)
        {
            for (int b = a + 1; b < nums.Length; b++)
            {
                for (int c = 0; c < nums.Length; c++)
                {
                    if (nums[a] + nums[b] == nums[c])
                    {
                        Console.WriteLine("{0} + {1} == {2}",
                            nums[a], nums[b], nums[c]);
                        tripleSums = true;
                    }
                }
            }
        }

        if (tripleSums == false)
        {
            Console.WriteLine("No");
        }

    }
}
