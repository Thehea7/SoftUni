//Read Input


double totalBudjet = double.Parse(Console.ReadLine());
string clas = Console.ReadLine();
int nGroup = int.Parse(Console.ReadLine());

//calculations

double ticketPrice = 0;
double budjet = 0;
double expences = 0;

switch(clas)
{
    case "Normal": ticketPrice = 249.99;
        break;
    case "VIP": ticketPrice = 499.99;
        break;
}
if (nGroup <= 4) { budjet = 0.25 * totalBudjet; }
else if(nGroup < 10) { budjet = 0.4 * totalBudjet; }
else if (nGroup < 25) { budjet = 0.5 * totalBudjet; }
else if (nGroup < 50) { budjet = 0.6 * totalBudjet; }
else { budjet = 0.75 * totalBudjet; };

expences = nGroup * ticketPrice;

// Print Output
if (budjet >=  expences)
{
    Console.WriteLine($"Yes! You have {budjet -expences:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {expences - budjet:f2} leva.");
}