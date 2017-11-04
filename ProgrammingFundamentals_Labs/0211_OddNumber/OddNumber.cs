using System;

class OddNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        while (input % 2 == 0)
        {
            Console.WriteLine("Please write an odd number.");
            input = int.Parse(Console.ReadLine());
        }

        if (input < 0)
        {
            input = Math.Abs(input);
        }
        Console.WriteLine($"The number is: {input}");

    }
}
