using System;
using System.Collections.Generic;
using System.Linq;

namespace _0707_CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();


            List<string> result = new List<string>();

            nums.Sort();

            int counter = 0;
            int temp = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == temp)
                {
                    counter++;
                    if (i == nums.Count - 1)
                    {
                        string line = temp + " -> " + counter;
                        result.Add(line);
                    }
                }
                else
                {
                    string line = temp + " -> " + counter;
                    result.Add(line);
                    counter = 1;
                    temp = nums[i];
                    if (i == nums.Count - 1)
                    {
                        line = temp + " -> " + counter;
                        result.Add(line);
                    }
                }
            }
            Console.WriteLine(String.Join("\r\n", result));
        }
    }
}
