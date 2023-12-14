using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using _05.TeamworkProjects;

namespace _05.TeamworkProjects
{
    class Team
    {
        public Team(string user, string team, List<string> participants)
        {
            Creator = user;
            TeamName = team;
            Participants = participants;
        }

        public string Creator { get; set; }

        public string TeamName { get; set; }


        public List<string> Participants { get; set; }

        public override string ToString()
        {
            return $"{TeamName}\n- {Creator}{Member(Participants)}";
        }

        public string Member(List<string> members)
        {
            members = members.OrderBy(x => x).ToList();
            string result = String.Empty;
            foreach (string member in members)
            {
               result += $"\n-- {member}";
            }

            return result;
        }
    }
}

internal class Program
{
    static void Main()
    {
        int numberOfTeams = int.Parse(Console.ReadLine());

        List<Team> teams = new List<Team>();

        for (int i = 0; i < numberOfTeams; i++)
        {
            string[] input = Console.ReadLine().Split('-').ToArray();
            string user = input[0];
            string team = input[1];
            List<string> currenList = new List<string>();
            Team newTeam = new Team(user, team, currenList);

            if (ConditionsToCreateATeam(user, team, teams))
            {
                teams.Add(newTeam);
                Console.WriteLine($"Team {team} has been created by {user}!");
            }
        }
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] arguments = command.Split("->");
            string user = arguments[0];
            string team = arguments[1];

            if (ConditionsToJoinATeam(user, team, teams))
            {
                int index = teams.FindIndex(x => x.TeamName == team);
                teams[index].Participants.Add(user);
            }
        }
        List<Team> emptyTeams = teams.Where(x => x.Participants.Count < 1).ToList();
        List<Team> removedEmpties = teams.Where(x => x.Participants.Count > 0).ToList();
        List<Team> ordereList = removedEmpties.OrderByDescending(x => x.Participants.Count)
            .ThenBy(x => x.TeamName)
            .ToList();

        ordereList.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("Teams to disband:");
        emptyTeams = emptyTeams.OrderBy(x => x.TeamName).ToList();
        emptyTeams.ForEach(x => Console.WriteLine(x.TeamName));
    }

    public static bool ConditionsToCreateATeam(string user, string teamName, List<Team> teams)
    {
        bool isTrue = true;

        foreach (Team team in teams)
        {
            if (team.TeamName == teamName)
            {
                Console.WriteLine($"Team {teamName} was already created!");
                return false;
            }
        }

        foreach (Team team in teams)
        {
            if (team.Creator == user)
            {
                Console.WriteLine($"{user} cannot create another team!");
                return false;
            }
        }

        return isTrue;
    }

    public static bool ConditionsToJoinATeam(string user, string teamName, List<Team> teams)
    {
        bool isTrue = true;
        if (teams.Exists(team => team.TeamName == teamName))
        {
            //do nothing
        }
        else
        {
            Console.WriteLine($"Team {teamName} does not exist!");
            return false;
        }

        if (teams.Any(x => x.Creator == user) ||
            teams.Any(x => x.Participants.Contains(user)))
        {
            Console.WriteLine($"Member {user} cannot join team {teamName}!");
            return false;
        }

        return isTrue;
    }
}
