namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            PrintTopSideOfTriangle(input);
            PrintBottomSideOfTriangle(input);
        }

        private static void PrintBottomSideOfTriangle(int input)
        {
            for (int i = input - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }

        private static void PrintTopSideOfTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
            }
        }
    }
}