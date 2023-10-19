var people = int.Parse(Console.ReadLine());
var typeOfGroup = Console.ReadLine();
var day =  Console.ReadLine();
double price = 0;
if (day == "Friday")
{
    switch (typeOfGroup)
    {
        case "Students":
            price = 8.45;
            break;
        case "Business":
            price = 10.9;
            break;
        case "Regular":
            price = 15;
            break;
    }
}
else if (day == "Saturday")
{
    switch (typeOfGroup)
    {
        case "Students":
            price = 9.8;
            break;
        case "Business":
            price = 15.6;
            break;
        case "Regular":
            price = 20;
            break;
    }
}
else if (day == "Sunday")
{
    switch (typeOfGroup)
    {
        case "Students":
            price = 10.46;
            break;
        case "Business":
            price = 16;
            break;
        case "Regular":
            price = 22.5;
            break;
    }
}
double totalPrice = people * price;

if (typeOfGroup == "Students" && people >= 30) totalPrice *= 0.85;
if (typeOfGroup == "Business" && people >=100)  totalPrice = (people - 10) * price;
if (typeOfGroup == "Regular" && people >= 10 && people <= 20) totalPrice *= 0.95;

Console.WriteLine($"Total price: {totalPrice:f2}");