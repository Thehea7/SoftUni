
int dancers = int.Parse(Console.ReadLine());
double points  = double.Parse(Console.ReadLine());
string season  = Console.ReadLine();
string destination = Console.ReadLine();

double award = 0;

if (destination == "Bulgaria")
{
    award = points * dancers;
    if (season == "summer") award *= 0.95;
    else if (season == "winter") award *= 0.92;

}
else if (destination == "Abroad")
{
    award = points * dancers + 0.5 * dancers * points;
    if (season == "summer") award *= 0.9;
    else if (season == "winter") award *= 0.85;
}

double charity = award * 0.75;
double amountPerDancer = 0.25  * award / dancers;


Console.WriteLine($"Charity - {charity:f2}");
Console.WriteLine($"Money per dancer - {amountPerDancer:f2}");