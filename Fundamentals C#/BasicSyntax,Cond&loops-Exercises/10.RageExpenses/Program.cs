int lostGames = int.Parse(Console.ReadLine());
double headsetPrice  = double.Parse(Console.ReadLine());
double mousePrice  = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice  = double.Parse(Console.ReadLine());
double expences = 0;
int count = 0;

for (int i = 1; i <= lostGames; i++)
{
    if (i %2 == 0)
    {
        expences += headsetPrice;
    }
    if (i %3 == 0) { expences += mousePrice; }

    if (i %2 == 0 && i % 3 ==0)
    {
        expences += keyboardPrice;
        count++;
        if (count % 2 == 0) { expences += displayPrice; }
    }
}

Console.WriteLine($"Rage expenses: {expences:f2} lv.");