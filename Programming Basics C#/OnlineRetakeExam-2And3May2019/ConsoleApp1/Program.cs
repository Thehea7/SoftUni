double budget = double.Parse(Console.ReadLine());


string product  = Console.ReadLine();
int productCount = 0;
double totalPrice = 0;
bool outOfMoney = false;

while (product != "Stop")
{
    double currentPrice = double.Parse(Console.ReadLine());
    productCount++;

    if (productCount % 3 == 0) currentPrice *= 0.5;

    if (budget - currentPrice < 0)
    {
        Console.WriteLine("You don't have enough money!");
        Console.WriteLine($"You need {currentPrice - budget:f2} leva!");
        outOfMoney = true;
        break;
    }

    budget -= currentPrice;
    totalPrice += currentPrice;
    product = Console.ReadLine();
}
if (!outOfMoney)
Console.WriteLine($"You bought {productCount} products for {totalPrice:f2} leva.");