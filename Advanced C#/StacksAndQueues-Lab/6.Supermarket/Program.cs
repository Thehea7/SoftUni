namespace _6.Supermarket
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                if (command != "Paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    Console.WriteLine(string.Join("\n", queue));
                    queue.Clear();
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}