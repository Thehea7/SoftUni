
int days = int.Parse(Console.ReadLine());
int  hours = int.Parse(Console.ReadLine());
double totalAmount = 0;

 for (int i = 1; i <= days; i++)
{
    double dayAmmount = 0;
    for (int j = 1; j <= hours; j++)
    {
        
        if (i % 2 == 0 && j % 2 != 0)
        {
            totalAmount += 2.5;
            dayAmmount += 2.5;
        }
        else if (i % 2 != 0 && j % 2 ==0)
        {
            totalAmount += 1.25;
            dayAmmount += 1.25;
        }
        else
        {
            totalAmount += 1;
            dayAmmount += 1;
        }
    }
    Console.WriteLine($"Day: {i} - {dayAmmount:f2} leva");
}
Console.WriteLine($"Total: {totalAmount:f2} leva");
    