

// Read Input

double requiredAmount = double.Parse(Console.ReadLine());
double startingCapital = double.Parse(Console.ReadLine());
int consequetiveSpend = 0;
int days = 0;
bool failed = false;

while (requiredAmount > startingCapital)
{
    string transaction = Console.ReadLine();
    double amount = double.Parse(Console.ReadLine());
    days++;

    if (transaction == "save")
    {
        startingCapital += amount;
        consequetiveSpend = 0;
    }
    else if (transaction == "spend")
    {
        consequetiveSpend++;
        startingCapital -= amount;
        if (startingCapital < 0) { startingCapital = 0; }
    }
    if (consequetiveSpend >= 5)
    {
        failed = true;
        break;
    }
}
if (failed)
{
    Console.WriteLine("You can't save the money.");
    Console.WriteLine(days);
}
else Console.WriteLine($"You saved the money for {days} days.");