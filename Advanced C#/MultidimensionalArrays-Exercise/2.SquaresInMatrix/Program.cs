namespace _2.SquaresInMatrix
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = size[0];
            int cols = size[1];


            string[,] matrix = new string[rows, cols];

            List<string[,]> listOfSquares = new List<string[,]>();

            for (int row = 0; row < rows; row++)
            {
                string[] arrayRow = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int column = 0; column < cols - 1; column++)
                {
                    string[,] square = new string[2, 2];
                    square[0, 0] = matrix[row,column];
                    square[0, 1] = matrix[row, column + 1];
                    square[1, 0] = matrix[row + 1, column];
                    square[1, 1] = matrix[row + 1, column + 1];
                    if (square[0, 0] == square[0, 1] && square[1, 0] == square[0, 1] && square[1, 1] == square[0, 1])
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}