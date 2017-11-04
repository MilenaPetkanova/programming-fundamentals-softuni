using System;
using System.Collections.Generic;
using System.Linq;

namespace _0702_ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            string[] commandLine = Console.ReadLine()
                .Split(' ').ToArray();
            string command = commandLine[0];
            
            while (command != "Odd" && command != "Even")
            {
                if (command == "Delete")
                {
                    int element = int.Parse(commandLine[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(element);
                    }
                            }
                else if (command == "Insert")
                {
                    int element = int.Parse(commandLine[1]);
                    int position = int.Parse(commandLine[2]);
                    numbers.Insert(position, element);
                }
                commandLine = Console.ReadLine().Split(' ').ToArray();
                command = commandLine[0];
            }

            List<int> result = new List<int>();
            if (command == "Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }
            else if (command == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        result.Add(numbers[i]);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
