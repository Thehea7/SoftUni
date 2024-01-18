namespace _1.ReverseAString
{
    internal class Program
    {
        static void Main()
        {
            Stack<char> reverseString = new Stack<char>(Console.ReadLine().ToCharArray());

            while (reverseString.Count != 0)
            {
                Console.Write(reverseString.Pop());
            }
        }
    }
}