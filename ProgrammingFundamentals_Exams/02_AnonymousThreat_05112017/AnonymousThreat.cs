using System;
using System.Collections.Generic;
using System.Linq;

class AnonymousThreat
{
    static void Main()
    {
        var inputList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> result = new List<string>(inputList);

        string command = Console.ReadLine();
        while (command != "3:1")
        {
            string[] tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (tokens[0] == "merge")
            {
                int startIndex = int.Parse(tokens[1]);
                int endIndex = int.Parse(tokens[2]);

                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > result.Count - 1)
                {
                    endIndex = result.Count - 1;
                }

                result = MergeSomeNumbers(result, startIndex, endIndex);
            }

            else if (tokens[0] == "divide")
            {
                int index = int.Parse(tokens[1]);
                int portion = int.Parse(tokens[2]);

                result = DivideSomeNumbers(result, index, portion);
            }

            command = Console.ReadLine();

        }

        Console.WriteLine(String.Join(" ", result));
    }

    private static List<string> DivideSomeNumbers(List<string> result, int index, int portion)
    {
        string choosen = result[index];

        int partitionsLength = choosen.Length / portion;

        string[] divided = new string[portion];

        for (int i = 0; i < portion; i++)
        {
            if (i == portion - 1)
            {
                divided[i] = choosen.Substring(i * partitionsLength);
            }
            else
            {
                divided[i] = choosen.Substring(i * partitionsLength, partitionsLength);
            }
        }

        result.RemoveAt(index);
        result.InsertRange(index, divided);

        return result;
    }

    private static List<string> MergeSomeNumbers(List<string> result, int startIndex, int endIndex)
    {
        for (int i = 0; i < result.Count; i++)
        {
            if (i == startIndex)
            {
                string merged = "";
                for (int j = startIndex; j <= endIndex; j++)
                {
                    merged = merged + result[startIndex];
                    result.RemoveAt(startIndex);
                }

                result.Insert(startIndex, merged);
            }
        }
        return result;

        //Another solution:
        //string merged = string.Empty;
        //if (startIndex < 0)
        //    startIndex = 0;
        //if (endIndex >= line.Length)
        //    endIndex = line.Length - 1;
        //for (int i = startIndex; i <= endIndex; i++)
        //    merged += line[i];
        //return line.Take(startIndex)
        //    .Concat(new[] { merged })
        //    .Concat(line.Skip(endIndex + 1))
        //    .ToArray();
    }
}
