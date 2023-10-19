double budget = double.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());
double pricePerNight = double.Parse(Console.ReadLine());
double additionalExpences = double.Parse(Console.ReadLine()) * budget / 100;

if (nights > 7) { pricePerNight *= 0.95; }

double totalExpences = nights * pricePerNight + additionalExpences;

if (budget >= totalExpences)
{
    Console.WriteLine($"Ivanovi will be left with {budget - totalExpences:f2} leva after vacation.");
}
else Console.WriteLine($"{totalExpences - budget:f2} leva needed.");