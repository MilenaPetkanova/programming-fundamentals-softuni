using System;

class SignOfIntegerNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        PrintSign(input);
    }

    private static void PrintSign(int inputNumber)
    {
        if (inputNumber > 0)
        {
            Console.WriteLine($"The number {inputNumber} is positive.");
        }
        else if (inputNumber < 0)
        {
            Console.WriteLine($"The number {inputNumber} is negative.");
        }
        else
        {
            Console.WriteLine($"The number {inputNumber} is zero.");
        }
    }
}
