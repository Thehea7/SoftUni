
string tournamentName = Console.ReadLine();
int currentEvents = 0;
int totalEvents = 0;
int eventsWon = 0;


while (tournamentName != "End of tournaments")
{
    currentEvents = int.Parse(Console.ReadLine());
    totalEvents += currentEvents;
    for (int i = 1; i <= currentEvents; i++)
    {
        int desiTeamPoints = int.Parse(Console.ReadLine());
        int awayTeamPoints = int.Parse(Console.ReadLine());
        if (desiTeamPoints > awayTeamPoints)
        {
            eventsWon++;

            Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {desiTeamPoints - awayTeamPoints} points.");
        }
        else 
            Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {awayTeamPoints - desiTeamPoints} points.");
    }

    tournamentName = Console.ReadLine();
}
double eventsWonPerCent = 100.00 * eventsWon / totalEvents;
Console.WriteLine($"{eventsWonPerCent:f2}% matches win");
Console.WriteLine($"{100 - eventsWonPerCent:f2}% matches lost");
