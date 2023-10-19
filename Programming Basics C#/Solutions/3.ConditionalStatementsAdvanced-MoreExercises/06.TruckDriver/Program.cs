// Read input

string season = Console.ReadLine();
double kmPerMonth = double.Parse(Console.ReadLine());

// Calculations
double payPerKm = 0;

if (kmPerMonth <= 5000)
{
    if (season == "Spring" ||  season == "Autumn"){ payPerKm = 0.75; }
    else if (season == "Summer") { payPerKm = 0.9; }
    else if(season == "Winter") { payPerKm = 1.05; }
}
else if (kmPerMonth <= 10000)
{
    if (season == "Spring" || season == "Autumn") { payPerKm = 0.95; }
    else if (season == "Summer") { payPerKm = 1.1; }
    else if (season == "Winter") { payPerKm = 1.25; }
}
else { payPerKm = 1.45; }

double netPay = payPerKm * kmPerMonth * 4 * 0.9;


// Print Output

Console.WriteLine($"{netPay:f2}");