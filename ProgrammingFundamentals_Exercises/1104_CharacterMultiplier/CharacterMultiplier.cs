using System;
using System.Linq;

class CharacterMultiplier
{
    static void Main()
    {
        var args = Console.ReadLine().Split(' ').ToArray();
        string firstStr = args[0];
        string secondStr = args[1];


        Console.WriteLine(MultiplyCharacters(firstStr, secondStr));
    }

    private static long MultiplyCharacters(string firstStr, string secondStr)
    {
        long totalSum = 0;

        if (firstStr.Length == secondStr.Length)
        {
            for (int i = 0; i < firstStr.Length; i++)
            {
                totalSum += firstStr.ElementAt(i) * secondStr.ElementAt(i);
            }
        }
        else
        {
            if (firstStr.Length > secondStr.Length)
            {
                for (int i = 0; i < secondStr.Length; i++)
                {
                    totalSum += firstStr.ElementAt(i) * secondStr.ElementAt(i);
                }
                for (int i = secondStr.Length; i < firstStr.Length; i++)
                {
                    totalSum += firstStr.ElementAt(i);
                }
            }
            else
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    totalSum += firstStr.ElementAt(i) * secondStr.ElementAt(i);
                }
                for (int i = firstStr.Length; i < secondStr.Length; i++)
                {
                    totalSum += secondStr.ElementAt(i);
                }
            }

        }

        return totalSum;

    }
}
