using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Team
{
    public string Name { get; set; }
    public int Points { get; set; }
    public int Goals { get; set; }
}

class FootballLeague
{
    static void Main()
    {
        var allTeams = new SortedDictionary<string, Team>();

        string key = Console.ReadLine();

        string game = Console.ReadLine();

        while (game != "final")
        {
            Regex validation = new Regex(@"(.*?)" + Regex.Escape(key)
                + @"(?<team1>[a-zA-Z]*)" + Regex.Escape(key)
                + @"(.*?)" + Regex.Escape(key)
                + @"(?<team2>[a-zA-Z]*)" + Regex.Escape(key)
                + @"(.*?)(?<result1>\d+):(?<result2>\d+)");

            Match playMatch = validation.Match(game);

            string team1 = playMatch.Groups["team1"].Value;
            team1 = ReverseString(team1).ToUpper();
            int goalsT1 = int.Parse(playMatch.Groups["result1"].ToString());

            string team2 = playMatch.Groups["team2"].Value;
            team2 = ReverseString(team2).ToUpper();
            int goalsT2 = int.Parse(playMatch.Groups["result2"].ToString());

            if (!allTeams.ContainsKey(team1))
            {
                Team teamD = new Team
                {
                    Name = team1,
                    Points = 0,
                    Goals = 0
                };

                allTeams.Add(team1, teamD);
            }

            allTeams[team1].Points += CalculatePoints(goalsT1, goalsT2);
            allTeams[team1].Goals += goalsT1;

            if (!allTeams.ContainsKey(team2))
            {
                Team teamG = new Team
                {
                    Name = team2,
                    Points = 0,
                    Goals = 0
                };

                allTeams.Add(team2, teamG);
            }

            allTeams[team2].Points += CalculatePoints(goalsT2, goalsT1);
            allTeams[team2].Goals += goalsT2;

            game = Console.ReadLine();
        }

        PrintResults(allTeams);
    }

    private static void PrintResults(SortedDictionary<string, Team> allTeams)
    {
        var sortedByStandings = allTeams.Values.OrderByDescending(x => x.Points)
            .ToDictionary(x => x.Name, y => y.Points);

        Console.WriteLine("League standings:");
        int standing = 1;
        foreach (var team in sortedByStandings)
        {
            Console.WriteLine("{0}. {1} {2}", standing, team.Key, team.Value);
            standing++;
        }

        var sortedByGoals = allTeams.Values.OrderByDescending(x => x.Goals)
            .ToDictionary(x => x.Name, y => y.Goals);

        Console.WriteLine("Top 3 scored goals:");
        int top3 = 1;
        foreach (var team in sortedByGoals)
        {
            if (top3 <= 3)
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
            top3++;
        }
    }

    public static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private static int CalculatePoints(int teamResult, int otherTeamResult)
    {
        int points = 0;
        if (teamResult == otherTeamResult)
        {
            points = 1;
        }
        else if (teamResult > otherTeamResult)
        {
            points = 3;
        }
        else if (teamResult < otherTeamResult)
        {
            points = 0;
        }

        return points;
    }
}
