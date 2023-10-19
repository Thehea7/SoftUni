
string moovie = Console.ReadLine();
string saloon  = Console.ReadLine();
int nTickets = int.Parse(Console.ReadLine());
double price = 0;
if (saloon == "normal")
{
    switch (moovie)
    {
        case "A Star Is Born": price = 7.50;
            break;
        case "Bohemian Rhapsody": price = 7.35;
            break;
        case "Green Book": price = 8.15;
            break;
        case "The Favourite": price = 8.75;
            break;
    }
}
else if (saloon == "luxury")
{
    switch (moovie)
    {
        case "A Star Is Born":
            price = 10.50;
            break;
        case "Bohemian Rhapsody":
            price = 9.45;
            break;
        case "Green Book":
            price = 10.25;
            break;
        case "The Favourite":
            price = 11.55;
            break;
    }
}
else if (saloon == "ultra luxury")
{
    switch (moovie)
    {
        case "A Star Is Born":
            price = 13.50;
            break;
        case "Bohemian Rhapsody":
            price = 12.75;
            break;
        case "Green Book":
            price = 13.25;
            break;
        case "The Favourite":
            price = 13.95;
            break;
    }
}



double income = nTickets * price;
Console.WriteLine($"{moovie} -> {income:f2} lv.");