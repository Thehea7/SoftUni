namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[squareMatrixSize, squareMatrixSize];

            for (int row = 0; row < squareMatrixSize; row++)
            {
                string[] arrayRow = string.Join(",", Console.ReadLine().ToCharArray()).Split(",");

                for (int col = 0; col < squareMatrixSize; col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }
            string filter = Console.ReadLine();
            for (int i = 0; i < squareMatrixSize; i++)
            {
                for (int j = 0; j < squareMatrixSize; j++)
                {
                    if (matrix[i, j] == filter)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{filter} does not occur in the matrix");
        }

    }
}