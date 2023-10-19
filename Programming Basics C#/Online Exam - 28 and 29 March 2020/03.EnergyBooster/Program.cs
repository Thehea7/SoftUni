string fruit = Console.ReadLine();
string size  = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

double price = 0;

if (size == "small")
{
    switch (fruit)
    {
        case "Watermelon":price = 56 * 2;
            break;
        case "Mango": price = 36.66 * 2;
            break;
        case "Pineapple":price = 42.1 * 2;
            break;
        case "Raspberry":price = 20 *2;
            break;
    }
}
if (size == "big")
{
    switch (fruit)
    {
        case "Watermelon":
            price = 28.7 * 5;
            break;
        case "Mango":
            price = 19.6 * 5;
            break;
        case "Pineapple":
            price = 24.8 * 5;
            break;
        case "Raspberry":
            price = 15.2 * 5;
            break;
    }
}

double totalAmmount = count * price;
if (totalAmmount > 1000) totalAmmount *= 0.5;
else if  (totalAmmount >= 400) totalAmmount *= 0.85;

Console.WriteLine($"{totalAmmount:f2} lv.");