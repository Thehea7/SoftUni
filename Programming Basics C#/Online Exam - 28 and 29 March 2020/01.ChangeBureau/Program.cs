
int bitcoin = int.Parse(Console.ReadLine());
double uoan  = double.Parse(Console.ReadLine());
double commission  = double.Parse(Console.ReadLine()) / 100;

double totalInEU = (bitcoin * 1168 + uoan * 0.15 * 1.76) / 1.95;
totalInEU = totalInEU - totalInEU * commission;

Console.WriteLine($"{totalInEU:f2}");