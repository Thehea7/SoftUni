
int capacity = int.Parse(Console.ReadLine());

string input = Console.ReadLine();
double income = 0;
while (input != "Movie time!")
{
    double currentPrice = 0;
    int people = int.Parse(input);
    if (capacity - people < 0)
    {
        Console.WriteLine($"The cinema is full.");
        break;
    }
    capacity -= people;
    currentPrice = people * 5;
    if (people % 3 == 0) currentPrice -= 5;
    income += currentPrice;
    input = Console.ReadLine();
}


if (input == "Movie time!")
{
    Console.WriteLine($"There are {capacity} seats left in the cinema.");
}
 Console.WriteLine($"Cinema income - {income} lv.");