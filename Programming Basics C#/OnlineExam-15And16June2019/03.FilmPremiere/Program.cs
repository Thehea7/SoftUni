
string moovie = Console.ReadLine();
string foodAndDrink  = Console.ReadLine();
int tickets = int.Parse(Console.ReadLine());
double price = 0;
if ( moovie == "John Wick")
{
    switch(foodAndDrink)
    {
        case "Drink":price = 12;
            break;
        case "Popcorn":price = 15;
            break;
        case "Menu":price = 19;
            break;
    }
}
else if(moovie == "Star Wars")
{
    switch (foodAndDrink)
    {
        case "Drink":
            price = 18;
            break;
        case "Popcorn":
            price = 25;
            break;
        case "Menu":
            price = 30;
            break;
    }
    if (tickets >= 4) price *= 0.7;
}
else if (moovie == "Jumanji")
{
    switch (foodAndDrink)
    {
        case "Drink":
            price = 9;
            break;
        case "Popcorn":
            price = 11;
            break;
        case "Menu":
            price = 14;
            break;
    }
    if (tickets == 2) price *= 0.85;
}
double totalPrice = price * tickets;
Console.WriteLine($"Your bill is {totalPrice:f2} leva.");