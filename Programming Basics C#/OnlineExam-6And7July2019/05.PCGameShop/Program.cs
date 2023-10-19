int n = int.Parse(Console.ReadLine());

int heartstone = 0;
int fortnite = 0;
int overwatch  = 0;
int others  = 0;
int total = 0;

for (int i = 0; i < n; i++)
{
    string game = Console.ReadLine();
    if (game == "Hearthstone") heartstone++;
    else if(game == "Fornite")fortnite++;
    else if (game == "Overwatch")overwatch++;
    else others++;
    total++;
}

Console.WriteLine($"Hearthstone - {100.0 * heartstone / total:f2}%");
Console.WriteLine($"Fornite - {100.0 * fortnite / total:f2}%");
Console.WriteLine($"Overwatch - {100.0 * overwatch / total:f2}%");
Console.WriteLine($"Others - {100.0 * others / total:f2}%");