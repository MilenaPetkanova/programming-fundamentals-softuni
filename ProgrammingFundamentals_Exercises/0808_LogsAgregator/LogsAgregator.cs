using System;
using System.Collections.Generic;
using System.Linq;

class LogsAgregator
{
    static void Main()
    {
        var report = new SortedDictionary<string, SortedDictionary<string, int>>();

        int logsCounter = int.Parse(Console.ReadLine());
        for (int i = 0; i < logsCounter; i++)
        {
            var inputLine = Console.ReadLine().Split(' ').ToArray();
            string ip = inputLine[0];
            string user = inputLine[1];
            int duration = int.Parse(inputLine[2]);

            if (!report.ContainsKey(user))
            {
                report.Add(user, new SortedDictionary<string, int>());
                report[user].Add(ip, duration);
            }
            else if (!report[user].ContainsKey(ip))
            {
                report[user].Add(ip, duration);
            }
            else
            {
                report[user][ip] += duration;
            }

        }

        var orderedUsers = report.OrderBy(x => x.Key);

        foreach (var user in orderedUsers)
        {
            List<int> userDur = user.Value
                .Select(x => x.Value).ToList();
            int userDuration = userDur.Sum();
            //Same result:
            //int userDuration = 0;
            //foreach (var dur in user.Value)
            //{
            //    userDuration += dur.Value;
            //}

            Console.Write("{0}: {1} [", user.Key, userDuration);

            var orderedIps = report[user.Key]
                .OrderBy(x => x.Key);
            List<string> userIps = new List<string>(); 
            foreach (var ip in orderedIps)
            {
                userIps.Add(ip.Key);
            }
            Console.Write(string.Join(", ", userIps));

            Console.WriteLine("]");    
        }
    }
}
