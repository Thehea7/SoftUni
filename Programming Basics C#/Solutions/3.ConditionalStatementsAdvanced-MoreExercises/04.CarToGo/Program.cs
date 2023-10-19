// Input

double budjet = double.Parse(Console.ReadLine());
string season  = Console.ReadLine();

//calculations

string carClass = "";
string carType = "";
double carPrice = 0;

switch (season)
{ case "Summer":
        if (budjet <= 100)
        {
            carClass = "Economy class";
            carType = "Cabrio";
            carPrice = budjet * 0.35;
        }
        else if (budjet <= 500)
        {
            carClass = "Compact class";
            carType = "Cabrio";
            carPrice = budjet * 0.45;
        }
        else
        {
            carClass = "Luxury class";
            carType = "Jeep";
            carPrice = budjet * 0.9;
        }
        break;
    case "Winter":
        if (budjet <= 100)
        {
            carClass = "Economy class";
            carType = "Jeep";
            carPrice = budjet * 0.65;
        }
        else if (budjet <= 500)
        {
            carClass = "Compact class";
            carType = "Jeep";
            carPrice = budjet * 0.80;
        }
        else
        {
            carClass = "Luxury class";
            carType = "Jeep";
            carPrice = budjet * 0.9;
        }
        break;
}



//Print Output
Console.WriteLine(carClass);
Console.WriteLine($"{carType} - {carPrice:f2}");