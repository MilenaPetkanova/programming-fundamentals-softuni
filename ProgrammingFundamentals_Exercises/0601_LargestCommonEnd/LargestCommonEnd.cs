using System;

namespace _0601_LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            if (firstLine.Length >= secondLine.Length)
            {
                Console.WriteLine(GetLargestCommonEnd(firstLine, secondLine));
            }
            else
            {
                Console.WriteLine(GetLargestCommonEnd(secondLine, firstLine));
            }
        }

        static int GetLargestCommonEnd(string[] firstLine, string[] secondLine)
        {
            string[] largerArr = new string[firstLine.Length];
            for (int i = 0; i < largerArr.Length; i++)
            {
                largerArr[i] = firstLine[i];
            }
            string[] shorterArr = new string[secondLine.Length];
            for (int i = 0; i < shorterArr.Length; i++)
            {
                shorterArr[i] = secondLine[i];
            }

            int counterLeft = 0;
            for (int i = 0; i < shorterArr.Length; i++)
            {
                if (shorterArr[i] == largerArr[i])
                {
                    counterLeft++;
                }
                else
                {
                    break;
                }
            }

            int counterRight = 0;
            for (int i = shorterArr.Length - 1; i >= 0; i--)
            {
                if (shorterArr[i] ==
                    largerArr[i + largerArr.Length - shorterArr.Length])
                {
                    counterRight++;
                }
                else
                {
                    break;
                }
            }

            return Math.Max(counterLeft, counterRight);
        }
    }
}
