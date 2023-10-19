
int daysOfAbsence = int.Parse(Console.ReadLine());
int leftFoodKG = int.Parse(Console.ReadLine());
double foodPerDayStag1 =  double.Parse(Console.ReadLine());
double foodPerDayStag2  = double.Parse(Console.ReadLine());
double foodPerDayStag3  = double.Parse(Console.ReadLine());

double foodRequired = (foodPerDayStag1 + foodPerDayStag2 + foodPerDayStag3) * daysOfAbsence;


if (foodRequired <= leftFoodKG)
{
    Console.WriteLine($"{Math.Floor(leftFoodKG - foodRequired)} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(foodRequired - leftFoodKG)} more kilos of food are needed.");
}
