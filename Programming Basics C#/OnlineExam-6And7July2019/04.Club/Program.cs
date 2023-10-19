double target = double.Parse(Console.ReadLine());

string drink = Console.ReadLine();
double income = 0;
while (drink != "Party!")
{
    int number = int.Parse(Console.ReadLine());
    int price = drink.Length;
    double orderPrice = price * number;
    if (orderPrice % 2 != 0) orderPrice *= 0.75;
    income += orderPrice;
    if (income >= target) break;

    drink = Console.ReadLine();
}


if (drink == "Party!")
{
    Console.WriteLine($"We need {target - income:f2} leva more.");
}
else
{
     Console.WriteLine("Target acquired.");
}
Console.WriteLine($"Club income - {income:f2} leva.");