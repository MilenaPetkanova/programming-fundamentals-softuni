using System;

class PrintTriangle
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        PrintTrianglePls(1, input);
    }

    static void PrintTrianglePls(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }

        for (int i = end - start; i >= start; i--)
        {
            for (int j = start; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
