namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int[][] matrix = new int[squareMatrixSize][];

            for (int i = 0; i < squareMatrixSize; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }
            int sum1 = 0;
            int sum2 = 0;
            for (int row = 0, col = squareMatrixSize - 1; row < squareMatrixSize && col >= 0; row++ , col--)
            {
                sum1 += matrix[row][row];
                sum2 += matrix[row][col];
            }

            Console.WriteLine($"{Math.Abs(sum1 - sum2)}");
        }
    }
}