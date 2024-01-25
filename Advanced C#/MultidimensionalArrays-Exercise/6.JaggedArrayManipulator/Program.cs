namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = ReadIntArray();
            }

            AnalyzeMatrix(matrix);

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();

                if (IsValid(matrix, arguments))
                {
                    int row = int.Parse(arguments[1]);
                    int col = int.Parse(arguments[2]);
                    int number = int.Parse(arguments[3]);

                    if (arguments[0] == "Add")
                    {
                        matrix[row][col] += number;
                    }
                    else
                    {
                        matrix[row][col] -= number;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static int[] ReadIntArray()
        {
            return  Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Select(int.Parse)
                .ToArray();
        }
        private static void AnalyzeMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row +1] = matrix[row +1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }
        }
        private static bool IsValid(int[][] matrix, string[] arguments)
        {
            bool isValid = true;
            if ((arguments[0] != "Subtract" && arguments[0] != "Add") 
                || arguments.Length != 4)
            {
                return false;
            }

            int row = int.Parse(arguments[1]);
            int col = int.Parse(arguments[2]);
            if (row < 0 
                || col < 0 
                || row >= matrix.GetLength(0) 
                || col >= matrix[row].Length)
            {
                return false;
            }

            return isValid;
        }
        private static void PrintMatrix (int[][] matrix)
        {
            foreach (var array in matrix)
            {
                Console.WriteLine(string.Join(" ", array));
            }
           
        }
    }
}