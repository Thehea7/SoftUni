

List< int> numbers = new List<int>();
int n = 1;
while (numbers.Count < 10)
{
    try
    {
        int a = Readnumber(n);
        numbers.Add(a);
        n = a;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");

    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(", ", numbers));


int Readnumber(int n)
{
    int a = int.Parse(Console.ReadLine());
    if (a  <= n || a >= 100)
    {
        throw new ArgumentException($"Your number is not in range {n} - 100!");
    }

    return a;
}