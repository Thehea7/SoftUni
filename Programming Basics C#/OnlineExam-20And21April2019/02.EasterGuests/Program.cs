

int guests = int.Parse(Console.ReadLine());
int budjet = int.Parse(Console.ReadLine());
double kosunak = Math.Ceiling(1.0 * guests / 3);
int eggs = guests * 2;




double expences = eggs * 0.45 + kosunak * 4;

if (budjet >= expences)
{
    Console.WriteLine($"Lyubo bought {kosunak} Easter bread and {eggs} eggs.");
    Console.WriteLine($"He has {budjet - expences:f2} lv. left.");
}
else
{
    Console.WriteLine($"Lyubo doesn't have enough money.");
    Console.WriteLine($"He needs {expences - budjet:f2} lv. more.");
}