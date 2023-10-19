
int input = int.Parse(Console.ReadLine());
int row = 1;
int digits = 0;



for (int d = 1; d <= input; d++)
{
    
        Console.Write($"{d} ");
        digits++;
    if (digits == row)
    {
        row++;
        Console.WriteLine();
        digits = 0;
    }
}
    


