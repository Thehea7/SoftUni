


try
{
    Console.WriteLine(GetSquareRoot());
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Goodbye.");
}
  double GetSquareRoot()
  {
      int input = int.Parse(Console.ReadLine());
    if (input < 0 )
    {
        throw new ArgumentException("Invalid number.");
    }
      return Math.Sqrt(input);
  }