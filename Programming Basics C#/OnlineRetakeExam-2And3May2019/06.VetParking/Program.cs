using System.Xml.Schema;

int days = int.Parse(Console.ReadLine());
int hoursPerDay  = int.Parse(Console.ReadLine());
double totalPrice = 0;

for (int i = 1; i <= days; i++)
{
    double pricePerDay = 0;
    for (int j = 1; j <= hoursPerDay; j++)
    {
        if (i % 2 == 0 && j % 2 != 0)
        {
            pricePerDay += 2.5;
        }
        else if (i % 2 != 0 && j % 2 == 0) { pricePerDay += 1.25; }
        else pricePerDay +=1;
    }
    Console.WriteLine($"Day: {i} - {pricePerDay:f2} leva");
    totalPrice += pricePerDay;
}

Console.WriteLine($"Total: {totalPrice:f2} leva");