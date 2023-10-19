
int kosunaci = int.Parse(Console.ReadLine());
int maxFloler = 0;
int maxSugar = 0;
int totalSugar = 0;
int totalFloler = 0;

for (int i = 0; i < kosunaci; i++)
{
    int sugarUsed = int.Parse(Console.ReadLine());
    int flolerUsed = int.Parse(Console.ReadLine());
    totalSugar += sugarUsed;
    totalFloler += flolerUsed;
    if (sugarUsed > maxSugar) maxSugar = sugarUsed;
    if (flolerUsed > maxFloler) maxFloler = flolerUsed;
}
double packetsSugar = Math.Ceiling(1.0 * totalSugar / 950);
double packetsFloler = Math.Ceiling(1.0 * totalFloler / 750);

Console.WriteLine($"Sugar: {packetsSugar}");
Console.WriteLine($"Flour: {packetsFloler}");
Console.WriteLine($"Max used flour is {maxFloler} grams, max used sugar is {maxSugar} grams.");