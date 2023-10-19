int customers = int.Parse(Console.ReadLine());


double totalMoneySpent = 0;
for (int i = 0; i < customers; i++)
{
    int itemsPerClient = 0;
    double moneySpent = 0;
    string purchase = Console.ReadLine();
    while (purchase != "Finish")
    {
        if (purchase == "basket")
        {
            moneySpent += 1.5;
        }
        else if (purchase == "wreath")
        {
            moneySpent += 3.8;
        }
        else if(purchase == "chocolate bunny")
        {
            moneySpent += 7;
        }
        itemsPerClient++;

        purchase = Console.ReadLine();
    }
    if (itemsPerClient % 2 == 0) { moneySpent *= 0.8; }
    totalMoneySpent += moneySpent;
    Console.WriteLine($"You purchased {itemsPerClient} items for {moneySpent:f2} leva.");
}

Console.WriteLine($"Average bill per client is: {totalMoneySpent / customers:f2} leva.");