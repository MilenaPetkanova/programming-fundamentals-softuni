using System;

class MultiplicationTable2
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int multiplier = int.Parse(Console.ReadLine());
        int product = 0;

        if (multiplier <= 10)
        {
            for (int i = multiplier; i <= 10; i++)
            {
                product = input * i;
                Console.WriteLine($"{input} X {i} = {product}");
            }
        }
        else
        {
            product = input * multiplier;
            Console.WriteLine($"{input} X {multiplier} = {product}");
        }
    }
}
