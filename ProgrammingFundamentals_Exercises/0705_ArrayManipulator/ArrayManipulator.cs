using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        var commandLine = Console.ReadLine().ToString();

        while (commandLine != "print")
        {
            string[] command = commandLine.Split(' ').ToArray();
            string action = command[0];

            if (action == "add")
            {
                numbers = AddNumbers(numbers, command);
            }
            else if (action == "addMany")
            {
                numbers = AddManyNumbers(numbers, command);
            }
            else if (action == "contains")
            {
                int element = Int32.Parse(command[1]);
                if (numbers.Contains(element))
                {
                    Console.WriteLine(numbers.IndexOf(element));
                }
                else
                { 
                    Console.WriteLine("-1");
                }
            }
            else if (action == "remove")
            {
                int index = Int32.Parse(command[1]);
                numbers.RemoveAt(index);
            }
            else if (action == "shift")
            {
                numbers = ShiftLeft(numbers, command);
            }
            else if (action == "sumPairs")
            {
                numbers = SumPairs(numbers, command);
            }

            commandLine = Console.ReadLine().ToString();
        }

        Console.WriteLine("[{0}]", String.Join(", ", numbers));
    }

    private static List<int> SumPairs(List<int> numbers, string[] command)
    {
        List<int> result = new List<int>();
        if (numbers.Count % 2 == 1)
        {
            numbers.Add(0);
        }
        for (int i = 0; i < numbers.Count - 1; i+=2)
        {
            int sum = numbers[i] + numbers[i + 1];
            result.Add(sum);
        }
        return result;
    }

    private static List<int> ShiftLeft(List<int> numbers, string[] command)
    {
        int shiftBy = int.Parse(command[1]);
        shiftBy = shiftBy % numbers.Count;

        var result = new List<int>(numbers);
        for (int i = 0; i < shiftBy; i++)
        {
            result.Add(result[0]);
            result.Remove(result[0]);
        }
        return result;
    }

    private static List<int> AddManyNumbers(List<int> numbers, string[] command)
    {
        int index = Int32.Parse(command[1]);
        int element = Int32.Parse(command[2]);
        numbers.Insert(index, element);

        for (int i = 3; i < command.Length; i++)
        {
            index++;
            element = Int32.Parse(command[i]);
            numbers.Insert(index, element);
        }
        return numbers;
    }

    static List<int> AddNumbers(List<int> numbers, string[] command)
    {
        int index = Int32.Parse(command[1]);
        int element = Int32.Parse(command[2]);
        numbers.Insert(index, element);
        return numbers;
    }
}
