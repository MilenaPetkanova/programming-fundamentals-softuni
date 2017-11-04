using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class RoliTheCoder
{
    static void Main()
    {
        var idsAndEvents = new Dictionary<string, string>();

        var eventsAndParticipants = new SortedDictionary<string,
            SortedSet<string>>();

        string input = Console.ReadLine();
        while (input != "Time for Code")
        {
            string validation = @"^(?<id>\d+)\s+#(?<event>\w+)(?<prtcpnts>((?:\s+@\w+)+)?)$";
            var match = Regex.Match(input, validation);

            if (match.Success)
            {
                var inputArgs = input.Split(new char[] { ' ', '\t', }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string id = inputArgs[0];
                string eventName = inputArgs[1].Remove(0, 1).ToString();

                if (idsAndEvents.ContainsKey(id) && !idsAndEvents.ContainsValue(eventName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                SortedSet<string> participants = new SortedSet<string>();

                if (inputArgs.Length > 2)
                {
                    for (int i = 2; i < inputArgs.Length; i++)
                    {
                        participants.Add(inputArgs[i].ToString());
                    }
                }

                if (!eventsAndParticipants.ContainsKey(eventName))
                {
                    idsAndEvents.Add(id, eventName);
                    eventsAndParticipants.Add(eventName, new SortedSet<string>());
                    eventsAndParticipants[eventName].UnionWith(participants);
                }
                else
                {
                    eventsAndParticipants[eventName].UnionWith(participants);
                }
            }


            input = Console.ReadLine();
        }

        var sortedEvents = new Dictionary<string, int>();
        foreach (var ev in eventsAndParticipants)
        {
            sortedEvents.Add(ev.Key, ev.Value.Count);
        }

        foreach (var evnt in sortedEvents.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{evnt.Key} - {evnt.Value}");

            var participants = eventsAndParticipants
                .Where(x => x.Key == evnt.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var participant in participants.Values)
            {
                foreach (var p in participant)
                {
                    Console.WriteLine($"{p}");

                }
            }
        }
    }
}
