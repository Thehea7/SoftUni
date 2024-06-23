namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main()
        {
            Queue<char> input = new Queue<char>(Console.ReadLine());

            Stack<char> brackets = new Stack<char>();

            if (input.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            while (input.Count > 0)
            {
                char currentChar = input.Dequeue();
                brackets.TryPeek(out var lastChar);
                if (isMatch(currentChar, lastChar))
                {
                    brackets.Pop();
                }
                else
                {
                    brackets.Push(currentChar);
                }
            }

            if (brackets.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }

        private static bool isMatch(char currentChar, char lastChar)
        {
            bool isMatch = false;

            if (currentChar == ')' && lastChar == '(') isMatch = true;
            if (currentChar == '}' && lastChar == '{') isMatch = true;
            if (currentChar == ']' && lastChar == '[') isMatch = true;

            return isMatch;
        }
    }
}