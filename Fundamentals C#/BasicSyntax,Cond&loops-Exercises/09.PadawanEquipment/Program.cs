double budget = double.Parse(Console.ReadLine());
int students  = int.Parse(Console.ReadLine());
double lightsaberPrice  = double.Parse(Console.ReadLine());
double robePrice  = double.Parse(Console.ReadLine());
double beltPrice  = double.Parse(Console.ReadLine());

double expences = lightsaberPrice * Math.Ceiling(students * 1.1) + robePrice * students + beltPrice * students - beltPrice * Math.Floor(1.0 * students / 6);

if (budget >= expences) Console.WriteLine($"The money is enough - it would cost {expences:f2}lv.");
else Console.WriteLine($"John will need {expences - budget:f2}lv more.");