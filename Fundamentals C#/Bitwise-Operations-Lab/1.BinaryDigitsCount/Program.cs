namespace _1.BinaryDigitsCount
{
    internal class Program
    {
        static void Main()
        {
          int input = int.Parse(Console.ReadLine());
          int binary = int.Parse(Console.ReadLine());
          int count = 0;
          while (input > 0)
          {
              int remainder = input % 2;
              input /= 2;
              if (remainder == binary)
              {
                  count++;
              }
          }
          Console.WriteLine(count);
        }
    }
}