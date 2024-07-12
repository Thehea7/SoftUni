

// Read Input

string stage = Console.ReadLine();
string ticket  = Console.ReadLine();
int nTickets  = int.Parse(Console.ReadLine());
char pic = Console.ReadLine()[0];
double ticketPrice = 0;

switch (stage)
{
    case "Quarter final":
        if (ticket == "Standard") ticketPrice = 55.5;
        if (ticket == "Premium") ticketPrice = 105.2;
        if (ticket == "VIP") ticketPrice = 118.9;
        break;

    case "Semi final":
        if (ticket == "Standard") ticketPrice = 75.88;
        if (ticket == "Premium") ticketPrice = 125.22;
        if (ticket == "VIP") ticketPrice = 300.4;
        break;

    case "Final":
        if (ticket == "Standard") ticketPrice = 110.1;
        if (ticket == "Premium") ticketPrice = 160.66;
        if (ticket == "VIP") ticketPrice = 400;
        break;

}

double totalPrice = ticketPrice * nTickets;
if (totalPrice > 4000) totalPrice = (0.75 * totalPrice);
else if (totalPrice > 2500)
{
    totalPrice = 0.9 * totalPrice;
    if (pic == 'Y') totalPrice += (nTickets * 40);
}
else if (pic == 'Y') totalPrice += (nTickets * 40);

Console.WriteLine($"{totalPrice}:f2");