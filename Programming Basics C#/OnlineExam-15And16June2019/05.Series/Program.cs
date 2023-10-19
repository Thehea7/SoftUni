double budget = double.Parse(Console.ReadLine());
int moovies  = int.Parse(Console.ReadLine());

for (int i = 0; i < moovies; i++)
{
    string title = Console.ReadLine();
    double curentPrice = double.Parse(Console.ReadLine());
    if (title == "Thrones") curentPrice *= 0.5;
    else if (title == "Lucifer") curentPrice *= 0.6;
    else if (title == "Protector") curentPrice *= 0.7;
    else if (title == "TotalDrama") curentPrice *= 0.8;
    else if (title == "Area") curentPrice *= 0.9;    
    budget -= curentPrice;
}

if  (budget >= 0)
{
    Console.WriteLine($"You bought all the series and left with {budget:f2} lv.");
}
else Console.WriteLine($"You need {Math.Abs(budget):f2} lv. more to buy the series!");