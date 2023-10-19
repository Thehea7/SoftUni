
string actor = Console.ReadLine();
double startingPoints = double.Parse(Console.ReadLine());
int juri = int.Parse(Console.ReadLine());


for (int i = 0; i < juri; i++)
{
    string juriName = Console.ReadLine();
    double currentPoints = double.Parse(Console.ReadLine());
    currentPoints = juriName.Length * currentPoints / 2;
    startingPoints += currentPoints;
    if (startingPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {startingPoints:f1}!");
        break;
    }
}

if (startingPoints <= 1250.5)
{
    Console.WriteLine($"Sorry, {actor} you need {1250.5 - startingPoints:f1} more!");
}