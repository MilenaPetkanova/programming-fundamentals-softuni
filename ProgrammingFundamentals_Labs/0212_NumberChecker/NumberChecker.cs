using System;

class NumberChecker
{
    static void Main()
    {
        try
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
