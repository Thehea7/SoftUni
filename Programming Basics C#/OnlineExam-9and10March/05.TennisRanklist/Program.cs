// Read Input

int nTournaments = int.Parse(Console.ReadLine());
int startingPoints  = int.Parse(Console.ReadLine());
int pointsWon = 0;
int tournamentsWon = 0;

for  (int i = 0; i < nTournaments; i++)
{
    string phase = Console.ReadLine();
    if (phase == "W")
    {
        pointsWon += 2000;
        tournamentsWon++;
    }
    else if (phase == "F") pointsWon += 1200;
    else if (phase == "SF") pointsWon += 720;
}

// Print Result


Console.WriteLine($"Final points: {startingPoints + pointsWon}");
Console.WriteLine($"Average points: {pointsWon / nTournaments}");
Console.WriteLine($"{100.00 * tournamentsWon / nTournaments:f2}%");