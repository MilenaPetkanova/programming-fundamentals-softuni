using System;

class ReverseArrayOfInteger
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(numbers);

        foreach (var num in numbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}