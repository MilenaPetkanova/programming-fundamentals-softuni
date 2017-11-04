using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Users { get; set; }
    public int MembersCounter { get; set; }
}

class TeamworkProject
{
    static void Main()
    {

        var allTeams = new SortedDictionary<string, Team>();
        var allUsers = new HashSet<string>();

        int teamsToRegister = int.Parse(Console.ReadLine());
        for (int i = 0; i < teamsToRegister; i++)
        {
            string[] inputTeamArgs = Console.ReadLine().Split('-');
            string creator = inputTeamArgs[0];
            string newTeam = inputTeamArgs[1];
            Team team = new Team()
            {
                Name = newTeam,
                Creator = creator,
                MembersCounter = 1,
                Users = new List<string>()
            };

            if (allTeams.Values.Any(x => x.Name == team.Name))
            {
                Console.WriteLine($"Team {team.Name} was already created!");
                continue;
            }

            if (allUsers.Contains(creator))
            //Same result:
            //if (allTeams.Values.Any(x => x.Creator == team.Creator))
            {
                Console.WriteLine($"{team.Creator} cannot create another team!");
                continue;
            }

            Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
            allTeams.Add(newTeam, team);
            allUsers.Add(creator);
        }

        string inputUser = Console.ReadLine();
        while (inputUser != "end of assignment")
        {
            string[] newUser = inputUser
                .Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
            string userName = newUser[0];
            string teamName = newUser[1];

            if (!allTeams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                inputUser = Console.ReadLine();
                continue;
            }

            if (allUsers.Contains(userName))
            {
                Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                inputUser = Console.ReadLine();
                continue;
            }

            if (allTeams.Values.Any(x => x.Name == teamName))
            {
                allTeams[teamName].Users.Add(userName);
                allTeams[teamName].MembersCounter++;
                allUsers.Add(userName);
                inputUser = Console.ReadLine();
                continue;
            }

            Team team = new Team()
            {
                Name = teamName,
                Users = new List<string>()
            };


            team.Users.Add(newUser[0]);
            team.MembersCounter++;

            inputUser = Console.ReadLine();
        }

        List<string> disbandedTeams = new List<string>();

        foreach (Team team in allTeams.Values
            .OrderByDescending(x => x.MembersCounter)
            .ThenBy(x => x.Name))
	    {
            if (team.MembersCounter == 1)
            {
                disbandedTeams.Add(team.Name);
                continue;
            }

            Console.WriteLine($"{team.Name}");
            Console.WriteLine($"- {team.Creator}");

            team.Users.Sort();
            foreach (var user in team.Users)
            {
                Console.WriteLine($"-- {user}");
            }
	    }
        
        Console.WriteLine("Teams to disband:");
        foreach (string disTeam in disbandedTeams)
        {
            Console.WriteLine(disTeam);
        }
    }

}
