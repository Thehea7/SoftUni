

// Read Input
int nTournaments = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());



// Calculations
int pointsWon = 0;
int tournamentsWon = 0;

for (int i = 0; i < nTournaments; i++)
{
    string position = Console.ReadLine();
    if (position == "W")
    {
        pointsWon += 2000;
        tournamentsWon++;
    }
    else if (position == "F") pointsWon += 1200;
    else if (position == "SF") pointsWon += 720;
}
int totalPoints = pointsWon + startingPoints;
Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(1.0 * pointsWon / nTournaments)}");
Console.WriteLine($"{100.00 * tournamentsWon / nTournaments:f2}%");