namespace _4.BitDestroyer
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int destroyer = 1;
            destroyer = destroyer << position;
            destroyer = ~destroyer;
            int output = input & destroyer;
            Console.WriteLine(output);
        }
    }
}