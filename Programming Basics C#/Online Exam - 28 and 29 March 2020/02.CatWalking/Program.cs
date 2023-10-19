int minutes = int.Parse(Console.ReadLine());
int walks  = int.Parse(Console.ReadLine());
int caloriesPerDay  = int.Parse(Console.ReadLine());

double currentcalories = minutes * 5 * walks;

if  (currentcalories >= caloriesPerDay * 0.5)
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {currentcalories}.");
}
else
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {currentcalories}.");