

int annualTax = int.Parse(Console.ReadLine());

double baskets = annualTax * 0.6;
double equip = baskets * 0.8;
double ball = equip * 0.25;
double others = ball * 0.2;

double totalAmmount = annualTax + baskets + others + equip + ball;

Console.WriteLine($"{totalAmmount:f2}");
