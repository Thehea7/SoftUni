string drink = Console.ReadLine();
string sugar = Console.ReadLine();
int nDrinks = int.Parse(Console.ReadLine());
double price = 0;

if (sugar == "Without")
{
    switch(drink)
    {
        case "Espresso":price = 0.9;
            break;
        case "Cappuccino":price = 1;
            break;
        case "Tea":price = 0.5;
            break;
    }
}
else if (sugar == "Normal")
{
    switch (drink)
    {
        case "Espresso":
            price = 1;
            break;
        case "Cappuccino":
            price = 1.2;
            break;
        case "Tea":
            price = 0.6;
            break;
    }
}
else if (sugar == "Extra")
{
    switch (drink)
    {
        case "Espresso":
            price = 1.2;
            break;
        case "Cappuccino":
            price = 1.6;
            break;
        case "Tea":
            price = 0.7;
            break;
    }
}
if (sugar == "Without") price *= 0.65;
if (drink == "Espresso" && nDrinks > 4) price *= 0.75;

double totalPrice = price * nDrinks;
if (totalPrice > 15) totalPrice *= 0.8;
Console.WriteLine($"You bought {nDrinks} cups of {drink} for {totalPrice:f2} lv.");