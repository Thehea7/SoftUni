
int fatsPerCent = int.Parse(Console.ReadLine());
int proteinsPerCent  = int.Parse(Console.ReadLine());
int vuglehidratiPerCent = int.Parse(Console.ReadLine());
int calories = int.Parse(Console.ReadLine());
int waterPerCent  = int.Parse(Console.ReadLine());

double fatsInGr = calories * fatsPerCent * 0.01 / 9;
double proteinsInGr = calories * proteinsPerCent * 0.01 / 4;
double vuglehidratiInGr = calories * vuglehidratiPerCent * 0.01 / 4;

double totalWeightInGr = fatsInGr + proteinsInGr + vuglehidratiInGr;

double averageCaloriesPerGram = (calories - (0.01 * waterPerCent * calories)) / totalWeightInGr;

Console.WriteLine($"{averageCaloriesPerGram:f4}");