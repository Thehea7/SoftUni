

// Read Input

string moovie = Console.ReadLine();
int totalTickets = 0;
int kid = 0;
int studen = 0;
int standart = 0;
int i = 0;

while ( moovie != "Finish")
{
    
    int seats = int.Parse(Console.ReadLine());
    string ticket = string.Empty;
    for (i = 0; i < seats && ticket != "End"; i++)
    {
        totalTickets++;
        ticket = Console.ReadLine();
        if (ticket == "standard") standart++;
        else if (ticket == "student") studen++;
        else if (ticket == "kid") kid++;
        else
        {
            totalTickets--;
            i--;
            continue;
        }
    }
    Console.WriteLine($"{moovie} - {100.00 * i / seats:f2}% full.");

    moovie = Console.ReadLine();
}
Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{100.00 * studen / totalTickets:f2}% student tickets.");
Console.WriteLine($"{100.00 * standart / totalTickets:f2}% standard tickets.");
Console.WriteLine($"{100.00 * kid / totalTickets:f2}% kids tickets.");

