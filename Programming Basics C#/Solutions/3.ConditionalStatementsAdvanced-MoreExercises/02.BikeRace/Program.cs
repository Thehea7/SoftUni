// Read Input

int juniors = int.Parse(Console.ReadLine());
int seniors  = int.Parse(Console.ReadLine());
string raceType = Console.ReadLine();

// Calculations

double juniorTax = 0;
double seniorTax = 0;

if (raceType == "trail")
{
    juniorTax = 5.5;
    seniorTax = 7;
}
else if (raceType == "cross-country")
{
    juniorTax = 8;
    seniorTax = 9.5;
    if (juniors + seniors >= 50)
    {
        juniorTax *= 0.75;
        seniorTax *= 0.75;
    }
}
else if (raceType == "downhill")
{
    juniorTax = 12.25;
    seniorTax = 13.75;
}
else if (raceType == "road")
{
    juniorTax = 20;
    seniorTax = 21.5;
}
double finalAmmount = (juniorTax * juniors + seniorTax * seniors) * 0.95;
Console.WriteLine($"{finalAmmount:f2}");