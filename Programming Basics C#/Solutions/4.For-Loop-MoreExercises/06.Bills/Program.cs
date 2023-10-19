

int months = int.Parse(Console.ReadLine());
int totalWater = months * 20;
int totalInternet = months * 15;
double totalPower = 0;
double totalOther = 0;
for (int i = 0; i < months; i++)
{
    double power = double.Parse(Console.ReadLine());
    totalPower += power;
    totalOther += ((power + 35) * 1.2);
}
double average = (totalPower + totalInternet + totalOther + totalWater) / months;

//Print Output

Console.WriteLine($"Electricity: {totalPower:f2} lv");
Console.WriteLine($"Water: {totalWater:f2} lv");
Console.WriteLine($"Internet: {totalInternet:f2} lv");
Console.WriteLine($"Other: {totalOther:f2} lv");
Console.WriteLine($"Average: {average:f2} lv");
