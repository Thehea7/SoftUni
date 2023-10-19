

//Read Input

double heritage = double.Parse(Console.ReadLine());
int y  = int.Parse(Console.ReadLine());
int age = 18;

//calculations

for (int i = 1800; i <= y; i++)
{
    if (i % 2  == 0)
    {
        heritage -= 12000;
        age++;
    }
    else { heritage -= (12000 + 50 * age++); }
}

if (heritage >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {heritage:f2} dollars left.");
}
else Console.WriteLine($"He will need {Math.Abs(heritage):f2} dollars to survive.");