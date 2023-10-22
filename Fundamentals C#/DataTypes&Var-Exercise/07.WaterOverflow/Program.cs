int lines = int.Parse(Console.ReadLine());
int capacity = 255;

for (int i = 0; i < lines; i++)
{
    int waterAdded = int.Parse(Console.ReadLine());
    if (waterAdded <= capacity)
    {
        capacity -= waterAdded;
    }
    else { Console.WriteLine("Insufficient capacity!"); }
}

Console.WriteLine(255 - capacity);