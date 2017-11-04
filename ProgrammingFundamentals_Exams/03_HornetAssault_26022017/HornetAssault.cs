using System;
using System.Collections.Generic;
using System.Linq;

class HornetAssault
{
    static void Main()
    {
        List<long> beehives = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToList();
        List<long> hornets = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToList();

        int beehivesStartCount = beehives.Count;

        for (int b = 0; b < beehivesStartCount; b++)
        {
            if (hornets.Count == 0)
            {
                break;
            }

            long hPower = hornets.Sum();
            beehives[b] -= hPower;

            if (beehives[b] < 0)
            {
                beehives[b] = 0;
            }
            else
            {
                hornets.RemoveAt(0);
            }
        }

        if (beehives.Any(x => x != 0))
        {
            beehives.RemoveAll(x => x == 0);
            Console.WriteLine(string.Join(" ", beehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}
