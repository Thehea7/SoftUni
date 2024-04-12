


string[] input = Console.ReadLine().Split(" ");
List<int> ints = new List<int>();
for (int i = 0; i < input.Length; i++)
{
    try
    {
        ints.Add(ParseElement(input[i]));


    }
    catch (FormatException e)
    {
        Console.WriteLine($"The element '{input[i]}' is in wrong format!");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"The element '{input[i]}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{input[i]}' processed - current sum: {ints.Sum()}");
    }
}

Console.WriteLine($"The total sum of all integers is: {ints.Sum()}");


int ParseElement(string s)
{
    return int.Parse(s);
}