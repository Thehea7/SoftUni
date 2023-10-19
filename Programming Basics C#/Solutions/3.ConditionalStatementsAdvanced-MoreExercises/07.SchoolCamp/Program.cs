// Read Input

string season = Console.ReadLine();
string gender = Console.ReadLine();
int students = int.Parse(Console.ReadLine());
int nights = int.Parse((Console.ReadLine()));

// calculate
double pricePerNight = 0;
string sport = "";

if (season == "Winter")
{
    if (gender == "girls")
    {
        pricePerNight = 9.6;
        sport = "Gymnastics";
    }
    else if (gender == "boys")
    {
        pricePerNight = 9.6;
        sport = "Judo";
    }
    else if (gender == "mixed")
    {
        pricePerNight = 10;
        sport = "Ski";
    }
}

else if (season == "Spring")
{
    if (gender == "girls")
    {
        pricePerNight = 7.2;
        sport = "Athletics";
    }
    else if (gender == "boys")
    {
        pricePerNight = 7.2;
        sport = "Tennis";
    }
    else if (gender == "mixed")
    {
        pricePerNight = 9.5;
        sport = "Cycling";
    }
}
else if(season == "Summer")
{
    if (gender == "girls")
    {
        pricePerNight = 15;
        sport = "Volleyball";
    }
    else if (gender == "boys")
    {
        pricePerNight = 15;
        sport = "Football";
    }
    else if (gender == "mixed")
    {
        pricePerNight = 20;
        sport = "Swimming";
    }
}
double discount = 1;
if (students >= 50) { discount = 0.5; }
else if (students >=20) { discount = 0.85; }
else if (students >=10) { discount = 0.95; }

double totalAmmount = pricePerNight * students * nights * discount;



// Print Output
Console.WriteLine($"{sport} {totalAmmount:f2} lv.");