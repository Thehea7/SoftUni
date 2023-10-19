
double budget = double.Parse(Console.ReadLine());

string input  = Console.ReadLine();

while (input != "ACTION")
{
    if (input.Length <= 15)
    {
        double payment = double.Parse(Console.ReadLine());
        if (budget - payment < 0)
        {
            Console.WriteLine($"We need {payment - budget:f2} leva for our actors.");
            break;
        }
        budget -= payment;
    }
    else budget *= 0.8;

    input = Console.ReadLine();
}

if (input == "ACTION")
{
    Console.WriteLine($"We are left with {budget:f2} leva.");
}


