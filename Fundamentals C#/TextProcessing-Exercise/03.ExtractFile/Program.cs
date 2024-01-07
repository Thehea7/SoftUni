namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { '\\', '.' });

            Console.WriteLine($"File name: {input[input.Length - 2]}");
            Console.WriteLine($"File extension: {input.Last()}");
        }
    }
}