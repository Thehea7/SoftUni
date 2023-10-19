
// Read Input

int hrizantemi = int.Parse(Console.ReadLine());
int roses = int.Parse(Console.ReadLine());
int laleta = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string day = Console.ReadLine();
bool holliday = day == "Y";

//calculations

double hrizantemiPrice = 0;
double rosesPrice = 0;
double laletaPrice = 0;


if (season == "Spring" || season == "Summer")
{
    hrizantemiPrice = 2;
    rosesPrice = 4.1;
    laletaPrice = 2.5;
}

else if (season == "Autumn" || season == "Winter")
{
    hrizantemiPrice = 3.75;
    rosesPrice = 4.5;
    laletaPrice = 4.15;
}
double boucketPrice = hrizantemi * hrizantemiPrice + rosesPrice * roses + laletaPrice * laleta;
if (holliday) { boucketPrice *= 1.15; }

if( season == "Spring" && laleta > 7) { boucketPrice *= 0.95; }
if (season == "Winter" && roses >=10) { boucketPrice *= 0.9; }
if (roses + hrizantemi + laleta > 20) { boucketPrice *= 0.8; }

Console.WriteLine($"{boucketPrice + 2:F2}");


