using System;
using System.Collections.Generic;
using System.Linq;

class Portal
{
    static void Main()
    {
        List<string> matrixRows = ReadMatrix(matrixSize);

        int matrixSize = int.Parse(Console.ReadLine());

        int[] startIndex = FindStartIndex(matrixRows);
        int row = startIndex[0];
        int column = startIndex[1];

        List<int[]> exitIndexes = FindExitIndexes(matrixRows);

        int stepsCounter = 0;
        bool exit = false;

        string directions = Console.ReadLine();
        foreach (var direction in directions)
        {
            if (direction == 'L')
            {
                if (column == 0)
                {
                    column = matrixRows[row].Length - 1;
                }
                else
                {
                    column -= 1;
                }
            }

            else if (direction == 'R')
            {
                if (column == matrixRows[row].Length - 1)
                {
                    column = 0;
                }
                else
                {
                    column += 1;
                }
            }

            else if (direction == 'D')
            {
                while (true)
                {
                    row++;
                    if (row > matrixRows.Count - 1)
                    {
                        row = 0;
                    }
                    if (column <= matrixRows[row].Count() - 1)
                    {
                        break;
                    }
                }
            }

            else if (direction == 'U')
            {
                while (true)
                {
                    row--;
                    if (row < 0)
                    {
                        row = matrixRows.Count - 1;
                    }
                    if (column <= matrixRows[row].Count() - 1)
                    {
                        break;
                    }
                }
            }

            stepsCounter++;

            int[] currentIndex = new int[2];
            currentIndex[0] = row;
            currentIndex[1] = column;

            if (exitIndexes.Any(currentIndex.SequenceEqual))
            {
                exit = true;
                Console.WriteLine($"Experiment successful. " +
                    $"{stepsCounter} turns required.");
                break;
            }
        }

        if (exit == false)
        {
            Console.WriteLine($"Robot stuck at {row} {column}. " +
                $"Experiment failed.");
        }

    }

    private static List<int[]> FindExitIndexes(List<string> matrix)
    {
        List <int[]> endIndexes = new List<int[]>();

        for (int i = 0; i < matrix.Count; i++)
        {
            if (matrix[i].Contains("E"))
            {
                int[] endIndex = new int[2];
                endIndex[0] = i;
                endIndex[1] = matrix[i].IndexOf("E");

                endIndexes.Add(endIndex);
            }
        }
        return endIndexes;
    }

    private static int[] FindStartIndex(List<string> matrix)
    {
        int[] startIndex = new int[2];
        for (int i = 0; i < matrix.Count; i++)
        {
            if (matrix[i].Contains("S"))
            {
                startIndex[0] = i;
                startIndex[1] = matrix[i].IndexOf("S");
            }
        }
        return startIndex;
    }

    private static List<string> ReadMatrix(int matrixSize)
    {
        List<string> matrix = new List<string>();

        for (int i = 0; i < matrixSize; i++)
        {
            string newRow = Console.ReadLine();

            //// Check if input is correct:
            //var sb = new StringBuilder();
            //foreach (var ch in newRow)
            //{
            //    if (ch == 'O'|| ch == 'S' || ch == 'E')
            //    {
            //        sb.Append(ch);
            //    }
            //}
            //newRow = sb.ToString();

            matrix.Add(newRow);
        }

        return matrix;
    }
}
