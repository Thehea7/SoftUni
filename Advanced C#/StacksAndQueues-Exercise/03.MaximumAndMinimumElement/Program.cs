namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                if (command == 1)
                {
                    stack.Push(int.Parse(input[1]));
                }
                else if (command == 2 && stack.Count >0)
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if(command == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}