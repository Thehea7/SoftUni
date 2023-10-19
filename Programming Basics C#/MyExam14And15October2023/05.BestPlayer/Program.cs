string player = Console.ReadLine();
string bestPlayer = "";
int moastGoals = int.MinValue;

while (player != "END")
{
    int goals = int.Parse(Console.ReadLine());
    if (goals >  moastGoals)
    {
        bestPlayer = player;
        moastGoals = goals;
        if (goals >= 10) break;
    }

    player = Console.ReadLine();
}

Console.WriteLine($"{bestPlayer} is the best player!");

if (moastGoals >= 3)
{
    Console.WriteLine($"He has scored {moastGoals} goals and made a hat-trick !!!");
}
else Console.WriteLine($"He has scored {moastGoals} goals.");