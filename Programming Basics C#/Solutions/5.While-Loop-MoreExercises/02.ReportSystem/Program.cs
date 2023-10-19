

// Read Input

int target = int.Parse(Console.ReadLine());
string input  = Console.ReadLine();
bool cash = true;
bool collected = false;
int cardTransactions = 0;
int cashTransactions = 0;
int cashAmmount = 0;
int cardAmmount = 0;

while (input != "End" & !collected)
{
    int currentPrice = int.Parse(input);

    if (cash)
    {
        if (currentPrice > 100) Console.WriteLine("Error in transaction!");
        else
        {
            Console.WriteLine("Product sold!");
            cashAmmount += currentPrice;
            target -= currentPrice;
            cashTransactions++;
        }
    }
    else
    {
        if (currentPrice < 10) Console.WriteLine("Error in transaction!");
        else
        {
            Console.WriteLine("Product sold!");
            cardAmmount += currentPrice;
            target -= currentPrice;
            cardTransactions++;
        }
    }

    if (target <= 0)
    {
        collected = true;
        break;
    }

    cash = !cash;
    input = Console.ReadLine();
}

if (collected)
{
    Console.WriteLine($"Average CS: {1.0 * cashAmmount / cashTransactions:f2}");
    Console.WriteLine($"Average CC: {1.0 * cardAmmount / cardTransactions:f2}");
}
else Console.WriteLine("Failed to collect required money for charity.");