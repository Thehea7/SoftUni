namespace _2.BitAtPosition1
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            input = input >> 1;

            int lsb = input & 1;
            Console.WriteLine(lsb);
        }
    }
}