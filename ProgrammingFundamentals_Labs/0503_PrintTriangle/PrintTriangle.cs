using System;

namespace _0503_PrintTriangle
{
    class PrintTriangle
    {
        static void Main(string[] args)
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
}
