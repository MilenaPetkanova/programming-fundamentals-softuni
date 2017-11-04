using System;

class DrawFilledSquare
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        PrintFilledSquare(input);
    }

    static void PrintFilledSquare(int n)
    {
        Console.WriteLine(new string('-', n * 2));
        FillSquare(n);
        Console.WriteLine(new string('-', n * 2));
    }

    static void FillSquare(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('-');
            for (int j = 0; j < n * 2 - 2; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write("/");
                }
            }
            Console.Write('-');
            Console.WriteLine();
        }
    }
}
