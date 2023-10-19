

//// Read Input
//int bottles = int.Parse(Console.ReadLine());

//// Calculations
//int detergent = 750 * bottles;
//string input = string.Empty;
//bool isOver = true;
//int counter = 0;
//int cleanDishes = 0;
//int cleanPots = 0;

//while (detergent >= 0)
//{

//    input = Console.ReadLine();
//    if (input == "End")
//    {
//        isOver = false;
//        break;
//    }
//    int vessels = int.Parse(input);
//    counter++;
//    if (counter < 3)
//    {
//        detergent -= (vessels * 5);
//        cleanDishes += vessels;
//    }
//    else
//    {
//        detergent -= (vessels * 15);
//        cleanPots += vessels;
//        counter = 0;
//    }

//}
//if  (!isOver)
//{
//    Console.WriteLine("Detergent was enough!");
//    Console.WriteLine($"{cleanDishes} dishes and {cleanPots} pots were washed.");
//    Console.WriteLine($"Leftover detergent {detergent} ml.");
//}
//else Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");

//SOLUTION 2

using System.Diagnostics.Metrics;

int bottles = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int detergent = 750 * bottles;
bool isOver = false;
int counter = 0;
int cleanDishes = 0;
int cleanPots = 0;

while (input != "End")
{
    int vessels = int.Parse(input);
    counter++;
    if (counter <3)
    {
        detergent -= (vessels * 5);
        cleanDishes += vessels;
    }
    else
    {
        detergent -= (vessels * 15);
        counter = 0;
        cleanPots += vessels;
    }
    if (detergent < 0)
    {
        isOver = true;
        break;
    }

    input = Console.ReadLine();
}
if (!isOver)
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{cleanDishes} dishes and {cleanPots} pots were washed.");
    Console.WriteLine($"Leftover detergent {detergent} ml.");
}
else Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");