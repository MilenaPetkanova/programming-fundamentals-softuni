using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main()
    {
        var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();
        while (input != "end")
        {
            string[] log = input.Split(' ').ToArray();
            string ip = log[0].Remove(0, 3);
            string message = log[1].Remove(0, 8);
            string user = log[2].Remove(0, 5);

            if (!userLogs.ContainsKey(user))
            {
                userLogs.Add(user, new Dictionary<string, int>());
            }
            if (!userLogs[user].ContainsKey(ip))
            {
                userLogs[user].Add(ip, 1);
            }
            else
            {
                userLogs[user][ip]++;
            }

            input = Console.ReadLine();
        }


        foreach (var user in userLogs)
        {
            Console.WriteLine("{0}:", user.Key);

            List<string> userIps = new List<string>();
            foreach (var ip in user.Value)
            {
                string ipAndCount = ip.Key + " => " + ip.Value;
                userIps.Add(ipAndCount);
            }

            Console.Write(string.Join(", ", userIps));
            Console.WriteLine(".");
        }
    }
}
