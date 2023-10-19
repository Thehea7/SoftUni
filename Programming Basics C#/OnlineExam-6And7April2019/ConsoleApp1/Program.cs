int rent = int.Parse(Console.ReadLine());

double statues = rent * 0.7;
double catering = statues * 0.85;
double sound = catering * 0.5;

double totalExpenses = rent + statues + catering + sound;

Console.WriteLine($"{totalExpenses:f2}");