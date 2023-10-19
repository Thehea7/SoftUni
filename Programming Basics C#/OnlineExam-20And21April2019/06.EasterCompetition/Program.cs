int kosunaci = int.Parse(Console.ReadLine());
int maxPoints = 0;
string bestChef = "";
for (int i = 0; i < kosunaci; i++)
{
    string chef = Console.ReadLine();
    int totalPoints = 0;
    string input = Console.ReadLine();
    while (input != "Stop")
    {
        totalPoints += int.Parse(input);

        input = Console.ReadLine();
    }
    Console.WriteLine($"{chef} has {totalPoints} points.");
    if (totalPoints > maxPoints)
    {
        Console.WriteLine($"{chef} is the new number 1!");
        maxPoints = totalPoints;
        bestChef = chef;
    }
}

Console.WriteLine($"{bestChef} won competition with {maxPoints} points!");