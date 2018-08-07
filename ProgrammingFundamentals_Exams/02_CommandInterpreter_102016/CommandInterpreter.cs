// !!!-UNFINISHED-!!!

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class CommandInterpreter
//{
//    static void Main()
//    {
//        List<string> collection = Console.ReadLine()
//            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//            .ToList();

//        //List<string> collection = new List<string>();

//        //foreach (string item in tokens)
//        //{
//        //    collection.Add(item);
//        //}

//        string command = Console.ReadLine();

//        while (command != "end")
//        {
//            var commandArgs = command.Split(' ').ToArray();
//            if (commandArgs[0] == "reverse")
//            {
//                int start = int.Parse(commandArgs[2]);
//                int count = int.Parse(commandArgs[4]);
//                if (count + start <= commandArgs.Length && start > 0 && start < commandArgs.Length - 1  && count > 0)
//                {
//                    List<string> portion = new List<string>();
//                    portion.AddRange(collection.Skip(start).Take(count));
//                    portion.Reverse();

//                    collection.RemoveRange(start, count);
//                    collection.InsertRange(start, portion);
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input parameters.");
//                }
//            }

//            else if (commandArgs[0] == "sort")
//            {
//                int start = int.Parse(commandArgs[2]);
//                int count = int.Parse(commandArgs[4]);
//                if (count + start <= commandArgs.Length
//                    && start > 0 && start < commandArgs.Length - 1
//                    && count > 0)
//                {
//                    List<string> portion = new List<string>();
//                    portion.AddRange(collection.Skip(start).Take(count));
//                    portion.Sort();

//                    collection.RemoveRange(start, count);
//                    collection.InsertRange(start, portion);
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input parameters.");
//                }
//            }

//            else if (commandArgs[0] == "rollLeft")
//            {
//                int count = int.Parse(commandArgs[1]);
//                count = count % collection.Count;
//                if (!(count < 0))
//                {
//                    for (int i = 0; i < count; i++)
//                    {
//                        collection.Add(collection[0]);
//                        collection.Remove(collection[0]);
//                    }
//                }
//            }

//            else if (commandArgs[0] == "rollRight")
//            {
//                int count = int.Parse(commandArgs[1]);
//                count = count % collection.Count;
//                if (!(count < 0))
//                {
//                    for (int i = 0; i < count; i++)
//                    {
//                        collection.Insert(0, collection[collection.Count - 1]);
//                        collection.RemoveAt(collection.Count - 1);
//                    }
//                }
//            }

//            command = Console.ReadLine();
//        }

//        Console.Write("[");
//        Console.Write(String.Join(", ", collection));
//        Console.Write("]");
//        Console.WriteLine();

//    }
//}
