
int eggs = int.Parse(Console.ReadLine());

string action = Console.ReadLine();
int eggsSold = 0;

while ( action != "Close")
{
    
    int numberEggs = int.Parse(Console.ReadLine());
    if (action == "Buy")
    {
        if (eggs - numberEggs < 0)
        {
            Console.WriteLine("Not enough eggs in store!");
            Console.WriteLine($"You can buy only {eggs}.");
            break;
        }
        eggs -= numberEggs;
        eggsSold += numberEggs;
    }
    else if (action == "Fill")
    {
        eggs += numberEggs;
    }


    action = Console.ReadLine();
}

if (action == "Close")
{
    Console.WriteLine("Store is closed!");
    Console.WriteLine($"{eggsSold} eggs sold.");
}