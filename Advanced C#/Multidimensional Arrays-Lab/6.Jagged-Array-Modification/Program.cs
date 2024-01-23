namespace _6.Jagged_Array_Modification
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split();
                int row = int.Parse(arguments[1]);
                int col = int.Parse(arguments[2]);
                int number = int.Parse(arguments[3]);

                if (row < 0 || col < 0 || row >= rows || col >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (arguments[0] == "Add")
                {
                    matrix[row][col] += number;
                }
                else
                {
                    matrix[row][col] -= number;
                }
            }
            foreach (var i in matrix)
            {
                Console.Write(string.Join(" ", i));
                Console.WriteLine();
            }
        }
    }
}