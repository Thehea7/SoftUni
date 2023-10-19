int nDays = int.Parse(Console.ReadLine());
double kilometarsPerDay1  = double.Parse(Console.ReadLine());
double totalKilometars = kilometarsPerDay1;
for (int i = 1; i <= nDays; i++)
{
    int kmIncreasePerDay = int.Parse(Console.ReadLine());
    kilometarsPerDay1 = 0.01 * kmIncreasePerDay * kilometarsPerDay1 + kilometarsPerDay1;
    totalKilometars += kilometarsPerDay1;
}

if  (totalKilometars >= 1000)
{
    Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKilometars - 1000)} more kilometers!");
}
else
    Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKilometars)} more kilometers");