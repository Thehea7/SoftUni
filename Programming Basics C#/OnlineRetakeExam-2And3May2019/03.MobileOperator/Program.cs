using System.Xml.Schema;

string years = Console.ReadLine();
string contract  = Console.ReadLine();
string internet  = Console.ReadLine();
int months = int.Parse(Console.ReadLine());

double paymentPerMonth = 0;

if (years == "one")
{
    switch (contract)
    {
        case "Small": paymentPerMonth = 9.98;
            break;
        case "Middle": paymentPerMonth = 18.99;
            break;
        case "Large": paymentPerMonth = 25.98;
            break;
        case "ExtraLarge": paymentPerMonth = 35.99;
            break;
    }
}
else if (years == "two")
{
    switch (contract)
    {
        case "Small":
            paymentPerMonth = 8.58;
            break;
        case "Middle":
            paymentPerMonth = 17.09;
            break;
        case "Large":
            paymentPerMonth = 23.59;
            break;
        case "ExtraLarge":
            paymentPerMonth = 31.79;
            break;
    }
}

if (internet == "yes")
{
    if (paymentPerMonth <= 10) paymentPerMonth += 5.5;
    else if (paymentPerMonth <= 30) paymentPerMonth += 4.35;
    else paymentPerMonth += 3.85;
}
if (years == "two") paymentPerMonth *= 0.9625;
double totalPayment = paymentPerMonth * months;
Console.WriteLine($"{totalPayment:f2} lv.");