using System;

class MultiplicationTable
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int product = 0;

        for (int i = 1; i <= 10; i++)
        {
            product = input * i;
            Console.WriteLine($"{input} X {i} = {product}");
        }
    }
}
