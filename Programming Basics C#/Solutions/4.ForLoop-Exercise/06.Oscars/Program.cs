

//Read Input
string actor = Console.ReadLine();
double totalPoints = double.Parse(Console.ReadLine());
int nJuri = int.Parse(Console.ReadLine());

// Calculation


for (int i = 0; i < nJuri; i++)
{
    string juriName = Console.ReadLine();
    double givenPoints = double.Parse(Console.ReadLine());
    double realPoints = juriName.Length * givenPoints / 2.0;
    totalPoints += realPoints;
    if (totalPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
        break;
    }
}
if (totalPoints < 1250.5)
System.Console.WriteLine($"Sorry, {actor} you need {1250.5 - totalPoints:f1} more!");
