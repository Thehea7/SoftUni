namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nWagon = int.Parse(Console.ReadLine());
            int sum = 0;
            string[] output = new string[nWagon];

            for (int i = 0; i < nWagon; i++)
            {
                string input = Console.ReadLine();
                sum += int.Parse(input);
                output[i] = input;

            }
            Console.WriteLine(string.Join(" ", output));
            Console.WriteLine(sum);
        }
    }
}