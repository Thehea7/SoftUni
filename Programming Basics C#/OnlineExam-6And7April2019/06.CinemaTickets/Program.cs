

string moovie = Console.ReadLine();
int totalTickets = 0;
int standart = 0;
int kid = 0;
int student = 0;

while (moovie != "Finish")
{
    string ticket = "";
    int currentTickets = 0;
    int freeSeats = int.Parse(Console.ReadLine());
    for (int i = 0; i < freeSeats; i++)
    {
        ticket = Console.ReadLine();
        if (ticket == "End") break;
        else if(ticket == "standard") standart++;
        else if(ticket == "kid") kid++;
        else if (ticket == "student") student++;
        totalTickets++;
        currentTickets++;
        
    }
    Console.WriteLine($"{moovie} - {100.00 * currentTickets / freeSeats:f2}% full.");

    moovie = Console.ReadLine();
}

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{100.0 * student / totalTickets:f2}% student tickets.");
Console.WriteLine($"{100.0 * standart / totalTickets:f2}% standard tickets.");
Console.WriteLine($"{100.0 * kid / totalTickets:f2}% kids tickets.");