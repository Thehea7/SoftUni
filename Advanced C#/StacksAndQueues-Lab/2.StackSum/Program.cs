namespace _2.StackSum
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> output = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] arguments = command.Split();
                int first = int.Parse(arguments[1]);
                if (arguments[0] == "add")
                {
                    output.Push(first);
                    output.Push(int.Parse(arguments[2]));
                }
                else if (arguments[0] == "remove" && first <= output.Count)
                {
                    for (int i = 0; i < first; i++)
                    {
                        output.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {output.Sum()}");
        }
    }
}