using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HornetArmada
{
    static void Main()
    {
        var allLegionsSoldiers = new Dictionary<string, Dictionary<string, long>>();

        var allActivities = new Dictionary<string, int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();

            Match match = Regex.Match(inputLine,
                @"(?<activity>\d+)\s=\s(?<legion>[^=\->,:\s]+)\s\-\>\s(?<type>[^=\->,:\s]+):(?<count>\d+)");

            string legionName = match.Groups["legion"].ToString();
            string soldierType = match.Groups["type"].ToString();
            int soldierCount = int.Parse(match.Groups["count"].ToString());
            int lastActivity = int.Parse(match.Groups["activity"].ToString());

            if (!allLegionsSoldiers.ContainsKey(legionName))
            {
                allLegionsSoldiers.Add(legionName, new Dictionary<string, long>());
                allLegionsSoldiers[legionName].Add(soldierType, soldierCount);

                allActivities.Add(legionName, lastActivity);
            }
            else if (!allLegionsSoldiers[legionName].ContainsKey(soldierType))
            {
                allLegionsSoldiers[legionName].Add(soldierType, soldierCount);
            }
            else
            {
                allLegionsSoldiers[legionName][soldierType] += soldierCount;
            }

            if (lastActivity > allActivities[legionName])
            {
                allActivities[legionName] = lastActivity;
            }
        }

        string[] query = Console.ReadLine().Split('\\').ToArray();

        if (query.Length == 1)
        {
            foreach (var activity in allActivities.OrderByDescending(x => x.Value))
            {
                if (allLegionsSoldiers[activity.Key].ContainsKey(query[0]))
                {
                    Console.WriteLine("{0} : {1}",
                        activity.Value, activity.Key);
                }
            }

        }

        else if (query.Length == 2)
        {
            int comparableActivity = int.Parse(query[0]);
            string soldierType = query[1];

            foreach (var legion in allLegionsSoldiers
                .Where(x => x.Value.ContainsKey(soldierType))
                .OrderByDescending(x => x.Value[soldierType]))
            {
                if (allActivities[legion.Key] < comparableActivity)
                {
                    Console.WriteLine("{0} -> {1}",
                        legion.Key,
                        legion.Value[soldierType]);
                }
            }

        }

    }
}
