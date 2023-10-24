int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string number1 = "";
    string number2 = "";
    string input = Console.ReadLine();
    bool spaceIsFound = false;
    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] == ' ')
        {
            spaceIsFound = true;
            continue;
        }
        if (!spaceIsFound)
        {
            number1 += input[j];
        }
        else number2 += input[j];
    }

    long number1Int = long.Parse(number1);
    long number2Int = long.Parse(number2);
    if (number1Int >= number2Int)
    {
        int sum1 = 0;
        while (Math.Abs(number1Int) > 0)
        {
            long lastDigit = number1Int % 10;
            sum1 += Math.Abs((int)lastDigit);
            number1Int /= 10;
        }
        Console.WriteLine(sum1);
    }
    else
    {
        int sum2 = 0;
        while (Math.Abs(number2Int) > 0)
        {
            long lastDigit = number2Int % 10;
            sum2 += Math.Abs((int)lastDigit);
            number2Int /= 10;
        }
        Console.WriteLine(sum2);
    }
}
        
    
    

 