namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main()
        {
            int[] size = ReadIntArray();
            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split();

                if (IsValid(arguments, matrix))
                {
                    int row1 = int.Parse(arguments[1]);
                    int col1 = int.Parse(arguments[2]);
                    int row2 = int.Parse(arguments[3]);
                    int col2 = int.Parse(arguments[4]);

                    (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        private static int[] ReadIntArray()
        {
            return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        private static bool IsValid(string[] arguments, string[,] matrix)
        {
            bool isValid = true;

            if (arguments.Length != 5 || arguments[0] != "swap")
            {
                return false;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int row1 = int.Parse(arguments[1]);
            int col1 = int.Parse(arguments[2]);
            int row2 = int.Parse(arguments[3]);
            int col2 = int.Parse(arguments[4]);

            if (row1 < 0 || row1 >= rows 
                         || col1 < 0 || col1 >= cols 
                         || row2 < 0 || row2 >= rows 
                         || col2 < 0 || col2 >= cols)
            {
                return false;
            }

            return isValid;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int rol = 0; rol < matrix.GetLength(0); rol++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[rol,col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}