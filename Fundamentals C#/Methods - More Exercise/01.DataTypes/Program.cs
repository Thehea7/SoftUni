namespace _01.DataTypes
{
    internal class Program
    {
        static void Main()
        {
            var type = Console.ReadLine();
            var input = Console.ReadLine();
            if (type == "int")TreatInput(int.Parse(input));
            else if (type == "real")TreatInput(double.Parse(input));
            else TreatInput(input);
        }

        private static void TreatInput(int input)
        {
            Console.WriteLine(input *2);
        }

        private static void TreatInput(double input)
        {
            Console.WriteLine($"{input * 1.5:f2}");
        }

        private static void TreatInput(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}