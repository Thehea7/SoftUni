string country = Console.ReadLine();
string discipline = Console.ReadLine();
double difficulty = 0;
double completition = 0;

switch (country)
{ 
    case "Russia":
        if (discipline == "ribbon")
        {
            difficulty = 9.1;
            completition = 9.4;
        }
        else if (discipline == "hoop")
        {
            difficulty = 9.3;
            completition = 9.8;
        }
        else if (discipline == "rope")
        {
            difficulty = 9.6;
            completition = 9;
        }
        break;
    case "Bulgaria":
        if (discipline == "ribbon")
        {
            difficulty = 9.6;
            completition = 9.4;
        }
        else if (discipline == "hoop")
        {
            difficulty = 9.55;
            completition = 9.75;
        }
        else if (discipline == "rope")
        {
            difficulty = 9.5;
            completition = 9.4;
        }
        break;
    case "Italy":
    if (discipline == "ribbon")
    {
        difficulty = 9.2;
        completition = 9.5;
    }
    else if (discipline == "hoop")
    {
        difficulty = 9.45;
        completition = 9.35;
    }
    else if (discipline == "rope")
    {
        difficulty = 9.7;
        completition = 9.15;
    }
    break;
}
double totalGrade = difficulty + completition;

// Print Output

Console.WriteLine($"The team of {country} get {totalGrade:f3} on {discipline}.");
Console.WriteLine($"{100 * (20 - totalGrade) / 20:f2}%");