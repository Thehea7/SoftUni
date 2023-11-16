namespace _3.N_thBit
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            input = input >> position;
           

            int lsb = input & 1;
            Console.WriteLine(lsb);
        }
    }
}