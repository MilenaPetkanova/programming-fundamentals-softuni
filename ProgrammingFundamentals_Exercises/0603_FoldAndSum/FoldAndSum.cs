using System;
using System.Linq;

namespace _0603_FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().
                        Split(' ').Select(int.Parse).ToArray();

            int chop = input.Length / 4;

            int[] firstLine = new int[chop * 2];
            int[] secondLine = new int[chop * 2];

            // Second line
            int index = 0;
            for (int i = chop; i < chop * 3; i++)
            {
                secondLine[index] = input[i];
                index++;
            }

            // Preparing first line
            int[] firstChop = new int[chop];
            for (int i = 0; i < chop; i++)
            {
                firstChop[i] = input[i];
            }
            Array.Reverse(firstChop);

            int[] fourthChop = new int[chop];
            index = 0;
            for (int i = chop * 3; i < input.Length; i++)
            {
                fourthChop[index] = input[i];
                index++;
            }
            Array.Reverse(fourthChop);

            // Joining chops to create the whole first line
            for (int i = 0; i < chop; i++)
            {
                firstLine[i] = firstChop[i];
            }
            index = 0;
            for (int i = chop; i < chop * 2; i++)
            {
                firstLine[i] = fourthChop[index];
                index++;
            }

            // Summing the lines
            int[] sum = new int[chop * 2];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstLine[i] + secondLine[i];
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
