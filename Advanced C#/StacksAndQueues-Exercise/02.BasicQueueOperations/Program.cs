namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> arguments = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int x = arguments.Pop();
            int dequeCount = arguments.Pop();
            int enqueCount = arguments.Pop();

            Queue<int> input = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Queue<int> queue = new Queue<int>();

            
            for (int i = 1, k = input.Count; i <= enqueCount && k > 0; i++, k--)
            {
                int currentNumber = input.Dequeue();
                queue.Enqueue(currentNumber);
                
            }
            for (int i = 0; i < dequeCount; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}