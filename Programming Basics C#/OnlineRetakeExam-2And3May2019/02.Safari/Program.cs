
double budget = double.Parse(Console.ReadLine());
double fuel = double.Parse(Console.ReadLine());
string day = Console.ReadLine();

double discount = 0;

if (day == "Saturday") discount = 0.9;
else if (day == "Sunday") discount = 0.8;

double expences = (100 + fuel * 2.1) * discount;


if (budget >= expences)
{
    Console.WriteLine($"Safari time! Money left: {budget - expences:f2} lv.");
}
else Console.WriteLine($"Not enough money! Money needed: {expences - budget:f2} lv.");