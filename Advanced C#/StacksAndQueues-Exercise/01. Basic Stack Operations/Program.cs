namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> arguments = new Stack<int>( Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int x = arguments.Pop();
            int popCount = arguments.Pop();
            int pushCount = arguments.Pop();

            Queue<int> input = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> stack = new Stack<int>();
            
            int xNumber = -1;
            for (int i = 1,  k = input.Count; i <= pushCount && k > 0; i++, k--)
            {
                int currentNumber = input.Dequeue();
                stack.Push(currentNumber);
                if (currentNumber == x)
                {
                    xNumber = i;
                }
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}