namespace _3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            int rows = squareMatrixSize;
            int cols = squareMatrixSize;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arrayRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }
            int sum = 0;

            for (int i = 0; i < squareMatrixSize; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}