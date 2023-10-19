
int turns = int.Parse(Console.ReadLine());
double totalPoints = 0;
int lessThan10 = 0;
int lessThan20 = 0;
int lessThan30 = 0;
int lessThan40 = 0;
int lessThan50 = 0;
int invalidNumbers = 0;



for (int i = 0; i < turns; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber < 0 || currentNumber > 50)
    {
        invalidNumbers++;
        totalPoints *= 0.5;
    }
    else if (currentNumber < 10)
    {
        lessThan10++;
        totalPoints += (currentNumber * 0.2);
    }
    else if(currentNumber < 20)
    {
        lessThan20++;
        totalPoints += (currentNumber * 0.3);
    }
    else if( currentNumber < 30)
    {
        lessThan30++;
        totalPoints += (currentNumber * 0.4);
    }
    else if(currentNumber < 40)
    {
        lessThan40++;
        totalPoints += 50;
    }
    else
    {
        lessThan50++;
        totalPoints += 100;
    }

}

Console.WriteLine($"{totalPoints:f2}");
Console.WriteLine($"From 0 to 9: {100.00 * lessThan10 / turns:f2}%");
Console.WriteLine($"From 10 to 19: {100.00 * lessThan20 / turns:f2}%");
Console.WriteLine($"From 20 to 29: {100.00 * lessThan30 / turns:f2}%");
Console.WriteLine($"From 30 to 39: {100.00 * lessThan40 / turns:f2}%");
Console.WriteLine($"From 40 to 50: {100.00 * lessThan50 / turns:f2}%");
Console.WriteLine($"Invalid numbers: {100.00 * invalidNumbers / turns:f2}%");