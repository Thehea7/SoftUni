double rocketPrice = double.Parse(Console.ReadLine());
int rockets = int.Parse(Console.ReadLine());
int baskets = int.Parse(Console.ReadLine());

double basketPrice = rocketPrice / 6.0;
double rocketsCost = rockets * rocketPrice;
double basketsCost = baskets * basketPrice;
double otherCost = (rocketsCost + basketsCost) * 0.2;
double totalCost = rocketsCost + basketsCost + otherCost;



Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalCost / 8)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalCost / 8 * 7)}");