
double budget = double.Parse(Console.ReadLine());
string destination  = Console.ReadLine();
string season  = Console.ReadLine();    
int days = int.Parse(Console.ReadLine());
double price = 0;


if (season == "Winter")
{
    switch (destination)
    {
        case "Dubai":price = 45000 * 0.7;
            break;
        case "Sofia":price = 17000 * 1.25;
            break;
        case "London":price = 24000;
            break;
    }
}
else if (season == "Summer")
{
    switch (destination)
    {
        case "Dubai":
            price = 40000 *0.7;
            break;
        case "Sofia":
            price = 12500 * 1.25;
            break;
        case "London":
            price = 20250;
            break;
    }
}





double expences = days * price;

if (budget >= expences)
{
    Console.WriteLine($"The budget for the movie is enough! We have {budget - expences:f2} leva left!");
}
else Console.WriteLine($"The director needs {expences - budget:f2} leva more!");