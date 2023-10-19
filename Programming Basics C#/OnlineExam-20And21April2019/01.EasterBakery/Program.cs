
double flourPrice = double.Parse(Console.ReadLine());
double flour = double.Parse(Console.ReadLine());
double sugar =  double.Parse(Console.ReadLine());
int eggs = int.Parse(Console.ReadLine());
int maq = int.Parse(Console.ReadLine());
double sugarPrice = flourPrice * 0.75;
double eggsPrice = flourPrice * 1.1;
double maqPrice = 0.2 * sugarPrice;

double expences = flour * flourPrice + sugar * sugarPrice + eggs * eggsPrice + maq * maqPrice;

Console.WriteLine($"{expences:f2}");