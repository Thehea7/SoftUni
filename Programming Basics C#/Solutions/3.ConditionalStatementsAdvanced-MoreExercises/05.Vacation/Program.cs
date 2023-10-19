// Read Input
double budjet = double.Parse(Console.ReadLine());
string season = Console.ReadLine();


// Calculations
double price = 0;
string location = "";
string accommodation = "";

   switch (season)
{
    case "Summer":
        location = "Alaska";
        if (budjet <= 1000)
        {
            accommodation = "Camp";
            price = budjet * 0.65;
        }
        else if (budjet <= 3000)
        {
            accommodation = "Hut";
            price = budjet * 0.8;
        }
        else 
        {
            accommodation = "Hotel";
            price = budjet * 0.9;
        }
        break;
    case "Winter":
        location = "Morocco";

        if (budjet <= 1000)
        {
            accommodation = "Camp";
            price = budjet * 0.45;
        }
        else if (budjet <= 3000)
        {
            accommodation = "Hut";
            price = budjet * 0.6;
        }
        else
        {
            accommodation = "Hotel";
            price = budjet * 0.9;
        }
        break;
        
}

//Print Output

Console.WriteLine($"{location} - {accommodation} - {price:f2}");