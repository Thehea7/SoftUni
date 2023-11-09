namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            var n1 = ReadInput(out var n2, out var n3);

            int sum = SumOfFirst2Numbers(n1, n2);
            int output = SubtractsThirdNumber(sum, n3);
            Console.WriteLine(output);

        }

        private static int ReadInput(out int n2, out int n3)
        {
            int n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            return n1;
        }

        private static int SumOfFirst2Numbers(int n1, int n2)
        {
            int result = n1 + n2;

            return result;
        }

        private static int SubtractsThirdNumber(int sum, int n3)
        {
            int result = sum - n3;

            return result;
        }
    }
}