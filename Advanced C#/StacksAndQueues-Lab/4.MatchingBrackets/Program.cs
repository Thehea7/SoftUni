namespace _4.MatchingBrackets
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> openBrackets = new Stack<int>();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBrackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = openBrackets.Pop();
                    string output = input.Substring(start, i - start + 1);
                    Console.WriteLine(output);
                }
            }
        }
    }
}