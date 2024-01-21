namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else
                {
                    Queue<string> songAdd = new Queue<string>(command.Split());
                    songAdd.Dequeue();
                    string songName = string.Join(" ", songAdd);
                    if (!queue.Contains(songName))
                    {
                        queue.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}