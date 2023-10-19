string input = Console.ReadLine();
double change = 0;

while (input != "Start")
{
    if (input == "0.1") change += 0.1;
    else if (input == "0.2") change += 0.2;
    else if (input == "0.5") change += 0.5;
    else if (input == "1") change += 1;
    else if (input == "2") change += 2;
    else Console.WriteLine($"Cannot accept {input}");

    input = Console.ReadLine();
}

string product = Console.ReadLine();

while (product != "End")
{
    if (product == "Nuts")
    {
        if (change >= 2) 
        { 
            change -= 2;
            Console.WriteLine("Purchased nuts");
        }
        else Console.WriteLine("Sorry, not enough money");
    }
    else if (product == "Water")
    {
        if (change >= 0.7)
        {
            change -= 0.7;
            Console.WriteLine("Purchased water");
        }
        else Console.WriteLine("Sorry, not enough money");
    }
    else if (product == "Crisps")
    {
        if (change >= 1.5)
        {
            change -= 1.5;
            Console.WriteLine("Purchased crisps");
        }
        else Console.WriteLine("Sorry, not enough money");
    }
    else if (product == "Soda")
    {
        if (change >= 0.8)
        {
            change -= 0.8;
            Console.WriteLine("Purchased soda");
        }
        else Console.WriteLine("Sorry, not enough money");
    }
    else if (product == "Coke")
    {
        if (change >= 1)
        {
            change -= 1;
            Console.WriteLine("Purchased coke");
        }
        else Console.WriteLine("Sorry, not enough money");
    }
    else { Console.WriteLine("Invalid product"); }
    product = Console.ReadLine();
}
Console.WriteLine($"Change: {change:f2}");