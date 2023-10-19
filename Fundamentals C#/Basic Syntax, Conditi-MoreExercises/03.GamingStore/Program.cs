double budget = double.Parse(Console.ReadLine());
double spent = 0;
string input  = Console.ReadLine();
while (input != "Game Time")
{
    double price = 0;
    if (input == "OutFall 4")
    {
        price = 39.99;
    }
    else if (input == "CS: OG")
    {
        price = 15.99;
    }
    else if (input == "Zplinter Zell")
    {
        price = 19.99;
    }
    else if (input == "Honored 2")
    {
        price = 59.99;
    }
    else if (input == "RoverWatch")
    {
        price = 29.99;
    }
    else if (input == "RoverWatch Origins Edition")
    {
        price = 39.99;
    }
    else
    {
        Console.WriteLine("Not Found");
        input = Console.ReadLine();
        continue;
    }

    if (budget  < price)
    {
        Console.WriteLine("Too Expensive");
        input = Console.ReadLine();
        continue;
    }
    else
    {
        budget -= price;
        spent += price;
        Console.WriteLine($"Bought {input}");
    }
    if (budget == 0)
    {
        Console.WriteLine("Out of money!");
        break;
    }



    input = Console.ReadLine();
}
if  (input == "Game Time")
{
    Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${budget:f2}");
}