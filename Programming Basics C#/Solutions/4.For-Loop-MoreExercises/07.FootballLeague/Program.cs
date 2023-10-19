
int capacity = int.Parse(Console.ReadLine());
int totalFens = int.Parse(Console.ReadLine());
int fansA = 0;
int fansB = 0;
int fansV = 0;
int fansG = 0;

for (int i = 0; i < totalFens; i++)
{
    string sector = Console.ReadLine();
    if (sector == "A") fansA++;
    else if (sector == "B") fansB++;
    else if (sector == "G") fansG++;
    else if (sector == "V") fansV++;
}

// Print Output

Console.WriteLine($"{100.00 * fansA / totalFens:f2}%");
Console.WriteLine($"{100.00 * fansB / totalFens:f2}%");
Console.WriteLine($"{100.00 * fansV / totalFens:f2}%");
Console.WriteLine($"{100.00 * fansG / totalFens:f2}%");
Console.WriteLine($"{100.00 * totalFens / capacity:f2}%");