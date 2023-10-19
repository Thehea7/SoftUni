
string size = Console.ReadLine();
string color  = Console.ReadLine();
int shipements = int.Parse(Console.ReadLine());
double price = 0;

switch (size)
{
    case "Large":
        switch (color)
        {
            case "Red": price = 16;
                break;
            case "Green": price = 12;
                break;
            case "Yellow": price = 9;
                break;
        }
        break;
    case "Medium":
        switch (color)
        {
            case "Red":
                price = 13;
                break;
            case "Green":
                price = 9;
                break;
            case "Yellow":
                price = 7;
                break;
        }
        break;
    case "Small":
        switch (color)
        {
            case "Red":
                price = 9;
                break;
            case "Green":
                price = 8;
                break;
            case "Yellow":
                price = 5;
                break;
        }
        break;
}


double income = shipements * price;
double profit = 0.65 * income;

Console.WriteLine($"{profit:f2} leva.");