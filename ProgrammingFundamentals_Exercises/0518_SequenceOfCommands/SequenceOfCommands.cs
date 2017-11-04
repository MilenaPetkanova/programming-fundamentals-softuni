using System;
using System.Collections;
using System.Linq;

namespace _0518_SequenceOfCommands
{
    class SequenceOfCommands
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            ArrayList output = new ArrayList();

            while (command[0] != "stop")
            {
                string action = command[0].ToString();
                long[] args = new long[2];

                if (action.Equals("add") ||
                    action.Equals("subtract") ||
                    action.Equals("multiply"))
                {
                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);
                }

                long[] result = PerformAction(numbers, action, args);
                output.Add(result);
                numbers = result;

                command = Console.ReadLine().Split(' ').ToArray();
            }
            PrintResults(output);
            Console.WriteLine('\n');
        }

        static long[] PerformAction(long[] numbers, string action, long[] args)
        {
            long[] result = numbers.Clone() as long[];

            int pos = (int)args[0] - 1;
            long value = args[1];

            switch (action)
            {
                case "multiply":
                    result[pos] *= value;
                    break;
                case "add":
                    result[pos] += value;
                    break;
                case "subtract":
                    result[pos] -= value;
                    break;
                case "lshift":
                    result = ArrayShiftLeft(result);
                    break;
                case "rshift":
                    result = ArrayShiftRight(result);
                    break;
            }
            return result;
        }

        private static long[] ArrayShiftRight(long[] result)
        {
            long lastNum = result[result.Length - 1];
            for (int i = result.Length - 1; i > 0; i--)
            {
                result[i] = result[i - 1];
            }
            result[0] = lastNum;
            return result;
        }

        private static long[] ArrayShiftLeft(long[] result)
        {
            long firstNum = result[0];
            for (int i = 0; i < result.Length - 1; i++)
            {
                result[i] = result[i + 1];
            }
            result[result.Length - 1] = firstNum;
            return result;
        }

        private static void PrintResults(ArrayList output)
        {
            foreach (long[] item in output)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write("{0} ", item[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
