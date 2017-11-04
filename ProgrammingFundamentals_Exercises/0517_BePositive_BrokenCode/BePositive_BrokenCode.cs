using System;
using System.Linq;
using System.Collections.Generic;

namespace _0517_BePositive_BrokenCode
{
    class BePositive_BrokenCode
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                int[] numbers = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                List<int> outputLines = new List<int>();

                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNum = numbers[j];
                    if (currentNum >= 0)
                    {
                        outputLines.Add(currentNum);
                    }
                    else
                    {
                        if (j == numbers.Length - 1)
                        {
                            break;
                        }
                        currentNum += numbers[j + 1];
                        if (currentNum >= 0)
                        {
                            outputLines.Add(currentNum);
                        }
                        j++;
                    }
                }
                if (outputLines.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", outputLines));
                }
                else
                {
                    Console.WriteLine("(empty)");
                }
            }
            
        }
    }
}
