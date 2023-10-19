

// Read Input

string input = Console.ReadLine();
double total = 0;
double feed = 0;
while (input != "NoMoreMoney")
{
    feed = double.Parse(input);
    if (feed >= 0)
    {
        Console.WriteLine($"Increase: {feed:f2}");
        total += feed;
        input = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Invalid operation!");
        Console.WriteLine($"Total: {total:f2}");
        break;
    }

}
if (feed >= 0) Console.WriteLine($"Total: {total:f2}");