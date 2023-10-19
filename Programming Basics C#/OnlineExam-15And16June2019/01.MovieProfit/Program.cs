string moovie = Console.ReadLine();
int days  = int.Parse(Console.ReadLine());
int tickets = int.Parse(Console.ReadLine());
double pricePerTicket = double.Parse(Console.ReadLine());
double saloonDeduction = double.Parse(Console.ReadLine());

double income = days * pricePerTicket * tickets; 
double profit = income - income * saloonDeduction / 100;

Console.WriteLine($"The profit from the movie {moovie} is {profit:f2} lv.");