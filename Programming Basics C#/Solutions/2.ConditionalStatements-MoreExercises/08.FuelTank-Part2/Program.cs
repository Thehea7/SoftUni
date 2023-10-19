

// Read Input

string fuel = Console.ReadLine();
double volume = double.Parse(Console.ReadLine());
string hasCard  = Console.ReadLine();
bool redoven = hasCard == "Yes";

//calculation

double price = 0;

double volumeDiscount  = 1;

switch (fuel)
{
    case "Diesel": price = 2.33;
        if (redoven)
        {
            price -= 0.12;
        }
        break;
    case "Gasoline": price = 2.22;
        if (redoven)
        {
            price -= 0.18;
        }
        break;
    case "Gas": price = 0.93; 
        if (redoven)
        {
            price -= 0.08;
        }
        break;

}
if (volume >=20 && volume <= 25) { volumeDiscount = 0.92; }
else if (volume >25) { volumeDiscount = 0.9; }

//Print output

double totalPrice = volume * price * volumeDiscount;
Console.WriteLine($"{totalPrice:f2} lv.");

