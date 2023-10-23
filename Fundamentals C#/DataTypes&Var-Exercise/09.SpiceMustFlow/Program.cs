int startingYield = int.Parse(Console.ReadLine());
long totalSpice = 0;
int days = 0;
while (startingYield >= 100)
{
    int spiceMinedToday = startingYield - 26;
    totalSpice += spiceMinedToday;
    days++;
    startingYield -= 10;
}
if (days > 0)
totalSpice -= 26;


Console.WriteLine(days);
Console.WriteLine(totalSpice);


