namespace _04.FastFood
{
    internal class Program
    {
        static void Main()
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(queue.Max());
            if (queue.Sum() <= food)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                while (food >= queue.Peek())
                {
                    food -= queue.Dequeue();
                }

                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}