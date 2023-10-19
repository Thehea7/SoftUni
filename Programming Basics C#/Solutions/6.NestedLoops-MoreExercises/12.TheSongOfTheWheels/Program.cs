
int control = int.Parse(Console.ReadLine());
int counter = 0;
string condition = "";

for (int a = 1; a <= 9; a++)
    for (int b = 1; b <= 9; b++)
        for (int c = 1; c <= 9; c++)
            for (int d = 1; d <= 9; d++)
            {
                if (a < b && c > d && (a*b + c*d == control))
                {
                    Console.Write($"{a}{b}{c}{d} ");
                    counter++;
                    if (counter == 4) { condition = $"Password: {a}{b}{c}{d}"; }
                }
            }

if (counter >= 4)
{
    Console.WriteLine();
    Console.WriteLine(condition);
}
else
{
    Console.WriteLine();
    Console.WriteLine("No!");
}