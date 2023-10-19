int people = int.Parse(Console.ReadLine());
double entrance = double.Parse(Console.ReadLine());
double shaiselongPrice  = double.Parse(Console.ReadLine());
double umbrellaPrice = double.Parse(Console.ReadLine());

double total = people * entrance + Math.Ceiling(people * 0.75) * shaiselongPrice + Math.Ceiling(people * 0.5 ) * umbrellaPrice;

Console.WriteLine($"{total:f2} lv.");