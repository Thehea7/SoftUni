int guests = int.Parse(Console.ReadLine());
double quvert = double.Parse(Console.ReadLine());
double budjet  = double.Parse(Console.ReadLine());

if (guests > 9 && guests <= 15) quvert *= 0.85;
else if (guests > 15 && guests <= 20) quvert *= 0.8;
else if (guests > 20) quvert *= 0.75;



double expences = guests * quvert + budjet * 0.1;

if (budjet >= expences)
{
    Console.WriteLine($"It is party time! {budjet - expences:f2} leva left.");
}
else
{
    Console.WriteLine($"No party! {expences - budjet:f2} leva needed.");
}