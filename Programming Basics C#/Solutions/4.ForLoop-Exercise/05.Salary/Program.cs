

// Read Input
int n = int.Parse(Console.ReadLine());
int pay = int.Parse(Console.ReadLine());



//calculation

for (int i = 0; i < n; i++)
{
    string site = Console.ReadLine();
    if (site == "Facebook")
    {
        pay -= 150;
    }
    else if (site == "Instagram")
    {
        pay -= 100;
    }
    else if(site == "Reddit")
    {
        pay -= 50;
    }
    if (pay <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        break;
    }
}
if (pay > 0) Console.WriteLine(pay);