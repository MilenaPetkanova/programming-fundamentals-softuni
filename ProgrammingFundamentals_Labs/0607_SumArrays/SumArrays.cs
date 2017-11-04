using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] first = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[] second = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        int biggerLenght = Math.Max(first.Length, second.Length);

        int[] sumArrays = new int[biggerLenght];

        for (int i = 0; i < biggerLenght; i++)
        {
            sumArrays[i] = first[i % first.Length] + second[i % second.Length];
        }

        Console.WriteLine(String.Join(" ", sumArrays));
    }
}
