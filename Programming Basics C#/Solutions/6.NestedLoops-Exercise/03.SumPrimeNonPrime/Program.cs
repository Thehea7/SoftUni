

string input = Console.ReadLine();
bool isPrime = true;
int primeSum = 0;
int nonPrimeSum = 0;

while (input != "stop")
{
    int curentNumber = int.Parse(input);
    if (curentNumber < 0)
    {
        Console.WriteLine("Number is negative.");
        input = Console.ReadLine();
        continue;
        
    }
    else if (curentNumber != 0) // 
    
    {
        for (int i = 2; i <= Math.Sqrt(curentNumber); i++)
        {
            if (curentNumber % i == 0) isPrime = false; 
            
        }
    }
    if (isPrime) { primeSum += curentNumber; }
    else nonPrimeSum += curentNumber;
    input = Console.ReadLine();
    isPrime = true;
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");

Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");