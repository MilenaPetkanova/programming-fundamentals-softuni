using System;
using System.Collections.Generic;
using System.Linq;

class SrubskoUnleashed
{
    static void Main()
    {
        var performance = new Dictionary<string, Dictionary<string, long>>();

        string input = Console.ReadLine();
        while (input != "End")
        {
            var inputArgs = input.Split('@');

            string singer = inputArgs[0];
            if (!singer.EndsWith(" "))
            {
                input = Console.ReadLine();
                continue;
            }
            singer = singer.Trim();

            string[] concertInfo = inputArgs[1].Split();
            if (concertInfo.Length < 3)
            {
                input = Console.ReadLine();
                continue;
            }

            string venue = null;
            for (int i = 0; i < concertInfo.Length - 2; i++)
            {
                venue += concertInfo[i] + " ";
            }
            venue = venue.Trim();

            long ticketCount = 0;
            bool succeedCount = long.
                TryParse(concertInfo[concertInfo.Length - 2],
                out ticketCount);
            if (!succeedCount)
            {
                input = Console.ReadLine();
                continue;
            }

            int ticketPrice = 0;
            bool succeedPrice = int.
                TryParse(concertInfo[concertInfo.Length - 1],
                out ticketPrice);
            if (!succeedPrice)
            {
                input = Console.ReadLine();
                continue;
            }

            long totalPrice = ticketPrice * ticketCount;

            if (!performance.ContainsKey(venue))
            {
                performance[venue] = new Dictionary<string, long>();
            }
            if (!performance[venue].ContainsKey(singer))
            {
                performance[venue][singer] = 0;
            }
            performance[venue][singer] += totalPrice;

            input = Console.ReadLine();
        }

        foreach (var venue in performance)
        {
            Console.WriteLine(venue.Key);

            foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
        
    }
}
