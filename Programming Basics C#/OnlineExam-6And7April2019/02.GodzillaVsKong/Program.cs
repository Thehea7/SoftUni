

double budjet = double.Parse(Console.ReadLine());
int nStatist = int.Parse(Console.ReadLine());
double clothingPerStatist  = double.Parse(Console.ReadLine());
double decor = 0.1 * budjet;
if (nStatist > 150) clothingPerStatist *= 0.9;
double expenses = nStatist * clothingPerStatist + decor;

if (expenses <= budjet)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budjet - expenses:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {expenses - budjet:f2} leva more.");
}