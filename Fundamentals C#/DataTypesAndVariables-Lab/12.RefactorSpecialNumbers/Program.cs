int input = int.Parse(Console.ReadLine());


for (int i = 1; i <= input; i++)
{
    int sum = 0;
    int currentNumber = i;
    while (currentNumber > 0)
    {
        int lastDigit  = currentNumber % 10;
        sum += lastDigit ;
        currentNumber /=  10;
    }
    bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
    Console.WriteLine("{0} -> {1}", i, isSpecial);
   
}