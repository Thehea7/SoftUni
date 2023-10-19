string destination = Console.ReadLine();

string packet = Console.ReadLine();
string vipYes  = Console.ReadLine();
bool vip = false;
if (vipYes == "yes") { vip = true; }
int days = int.Parse(Console.ReadLine());
double price = 0;
bool isValid = true;

if (destination == "Bansko" || destination == "Borovets")
{
    switch (packet)
    {
        case "withEquipment": price = 100;
            if (vip) { price *= 0.9; }
            break;
        case "noEquipment": price = 80;
            if (vip) { price *= 0.95; }
            break;
        default:isValid = false; break;  
    }
}
else if (destination == "Varna" || destination == "Burgas")
{
    switch (packet)
    {
        case "withBreakfast":
            price = 130;
            if (vip) { price *= 0.88; }
            break;
        case "noBreakfast":
            price = 100;
            if (vip) { price *= 0.92; }
            break;
            default :isValid = false; break;
    }
}
else { isValid = false; }
if (days > 7) days--;
double totalPrice = days * price;


if (days < 1) Console.WriteLine("Days must be positive number!");
if (!isValid) Console.WriteLine("Invalid input!");
if(isValid && days >1) Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");