using _05.FootballTeamGenerator;

string commands;
Dictionary<string, Team> teamMap = new Dictionary<string, Team>();

while ((commands = Console.ReadLine()).ToLower() != "end")
{
    string[] arguments = commands.Split(";", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];
    string teamName = arguments[1];
    try
    {
        switch (command.ToLower())
        {
            case "team":
                AddTeam(arguments, teamMap);
                break;
            case "add":
                AddPlayer(arguments, teamMap);
                break;
            case "remove":
                string playerName = arguments[2];
                teamMap[teamName].Remove(playerName);
                break;
            case "rating":
                PrintRating(teamName, teamMap);
                break;
        }
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}


static void AddTeam(string[] strings, Dictionary<string, Team> teams)
{
    string name = strings[1];
    if (teams.ContainsKey(name) == false)
    {
        teams.Add(name, new Team(name));                
    }
}

static void AddPlayer(string[] strings, Dictionary<string, Team> dictionary)
{
    string teamName = strings[1];
    string playerName = strings[2];
    List<int> stats = strings.Skip(3).Select(int.Parse).ToList();
    if (dictionary.ContainsKey(teamName) == false)
    {
        throw new ArgumentException($"Team {teamName} does not exist.");
    }
    dictionary[teamName].AddPlayer(new Player(playerName,stats));
}

static void PrintRating(string name, Dictionary<string, Team> teamMap)
{
    if (teamMap.ContainsKey(name) == false)
    {
        throw new ArgumentException($"Team {name} does not exist.");
    }

    Console.WriteLine(teamMap[name]);
}