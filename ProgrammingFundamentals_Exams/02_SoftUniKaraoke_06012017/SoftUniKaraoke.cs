using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniKaraoke
{
    static void Main()
    {
        var list = new List<string>();
        var allParticipants = new SortedDictionary<string, List<string>>();
        var awardsCounter = new SortedDictionary<string, int>();

        string[] participants = Console.ReadLine()
            .Split(',').Select(s => s.Trim()).ToArray();
        string[] songs = Console.ReadLine()
            .Split(',').Select(s => s.Trim()).ToArray();
        string command = Console.ReadLine();

        foreach (var participant in participants)
        {
            list.Add(participant);
        }
        foreach (var song in songs)
        {
            list.Add(song);
        }

        while (command != "dawn")
        {
            string[] performance = command
                .Split(',').Select(s => s.Trim()).ToArray();
            string name = performance[0];
            string song = performance[1];
            string award = performance[2];

            if (list.Contains(name) && list.Contains(song))
            {
                if (!allParticipants.ContainsKey(name))
                {
                    allParticipants.Add(name, new List<string>());
                    allParticipants[name].Add(award);
                    awardsCounter.Add(name, 1);
                }
                else if (!allParticipants[name].Contains(award))
                {
                    allParticipants[name].Add(award);
                    awardsCounter[name]++;
                }
            }

            command = Console.ReadLine();
        }

        int counter = 0;
        foreach (var participant in awardsCounter.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0}: {1} awards", 
                participant.Key, participant.Value);
            foreach (var award in allParticipants[participant.Key].OrderBy(x => x))
            {
                Console.WriteLine("--{0}", award);
                counter++;
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No awards");
        }
    }
}
