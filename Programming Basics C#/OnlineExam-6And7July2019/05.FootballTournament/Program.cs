string team = Console.ReadLine();
int games = int.Parse(Console.ReadLine());
int Points = 0;
int gamesWon = 0;
int gamesDraw = 0;
int gamesLost = 0;


for (int i = 0; i < games; i++)
{
    string input = Console.ReadLine();
    if (input == "W")
    {
        gamesWon++;
        Points += 3;
    }
    else if (input == "D")
    {
        gamesDraw++;
        Points += 1;
    }
    else if (input == "L") { gamesLost++; }


}

if (games == 0) Console.WriteLine($"{team} hasn't played any games during this season.");
else
{
    Console.WriteLine($"{team} has won {Points} points during this season.");
    Console.WriteLine("Total stats:");
    Console.WriteLine($"## W: {gamesWon}");
    Console.WriteLine($"## D: {gamesDraw}");
    Console.WriteLine($"## L: {gamesLost}");
    Console.WriteLine($"Win rate: {100.0 * gamesWon /games:f2}%");
}