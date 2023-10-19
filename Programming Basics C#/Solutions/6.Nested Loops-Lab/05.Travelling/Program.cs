
// Read Input

string destination = Console.ReadLine();

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double moneySaved = 0;
    while (budget > moneySaved)
    {
        double transaction = double.Parse(Console.ReadLine());
        moneySaved += transaction;
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();
}