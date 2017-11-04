using System;

class CharityMarathon
{
    static void Main(string[] args)
    {
        short days = short.Parse(Console.ReadLine());
        long runners = long.Parse(Console.ReadLine());
        byte lapsPerRunner = byte.Parse(Console.ReadLine());
        int lapLength = int.Parse(Console.ReadLine());
        short capacity = short.Parse(Console.ReadLine());
        decimal moneyPerKm = decimal.Parse(Console.ReadLine());

        long runnersMax = days * capacity;

        if (runners > runnersMax)
        {
            runners = runnersMax;
        }

        long metersTotal = (runners * lapsPerRunner * lapLength) / 1000;

        decimal money = metersTotal * moneyPerKm;

        Console.WriteLine("Money raised: {0:0.00}", money);
    }
}
