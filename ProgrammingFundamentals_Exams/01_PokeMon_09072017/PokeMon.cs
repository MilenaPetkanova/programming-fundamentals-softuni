using System;

class PokeMon
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int y = int.Parse(Console.ReadLine());
        int exhN = n / 2;

        int countPokes = 0;

        while (true)
        {
            n -= m;
            countPokes++;

            if (n == exhN)
            {
                if (y != 0)
                {
                    n = n / y;
                }
            }
            
            if (n < m)
            {
                break;
            }
        }

        Console.WriteLine(n);
        Console.WriteLine(countPokes);
    }
}
