// Read Input

int controlTimeminutes = int.Parse(Console.ReadLine());
int controlTimeSeconds = int.Parse(Console.ReadLine());
double trip = double.Parse(Console.ReadLine());
int timePer100m = int.Parse(Console.ReadLine());

int controlTime = controlTimeminutes * 60 + controlTimeSeconds;

double realTime = timePer100m * trip / 100 - 2.5 * trip / 120;

if (realTime > controlTime) Console.WriteLine($"No, Marin failed! He was {realTime - controlTime:f3} second slower.");
else
{
    Console.WriteLine($"Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {realTime:f3}.");

}
