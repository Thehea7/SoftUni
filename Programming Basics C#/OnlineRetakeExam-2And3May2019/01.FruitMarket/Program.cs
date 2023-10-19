
double strawberyPrice = double.Parse(Console.ReadLine());
double bananas = double.Parse(Console.ReadLine());
double oranges  = double.Parse(Console.ReadLine());
double rasbery  = double.Parse(Console.ReadLine());
double strawbery  = double.Parse(Console.ReadLine());
double rasberyPrice = strawberyPrice * 0.5;
double orangePrice = rasberyPrice * 0.6;
double bananaPrice = rasberyPrice * 0.2;

double expences = strawbery * strawberyPrice + bananas * bananaPrice + oranges * orangePrice + rasbery * rasberyPrice;

Console.WriteLine($"{expences:f2}");