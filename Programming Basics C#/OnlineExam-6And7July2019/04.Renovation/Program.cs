int h = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
int unUsedSpacePerCent = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
double spaceToBePainted = Math.Ceiling(4 *h * l - (0.04 * h * l * unUsedSpacePerCent));

while (input != "Tired!")
{
    int paint = int.Parse(input);
    spaceToBePainted -= paint;
    if (spaceToBePainted <= 0) break;

    input = Console.ReadLine();
}

if (input == "Tired!")
{
    Console.WriteLine($"{spaceToBePainted} quadratic m left.");
}
else if (spaceToBePainted == 0) Console.WriteLine($"All walls are painted! Great job, Pesho!");
else
Console.WriteLine($"All walls are painted and you have {Math.Abs(spaceToBePainted)} l paint left!" );
