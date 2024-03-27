internal class Program
{
    public static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(number));


    }
    private static long Factorial(long number)
    {
        if (number == 0)
        {
            return 1;
        }
        var result = number * Factorial(number - 1);

        return result;
    }
}