namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> input = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int wracks = 0;
            int volumeLeft = 0;

            while (input.Count > 0)
            {
                if (volumeLeft >= input.Peek())
                {
                    volumeLeft -= input.Pop();
                }
                else
                {
                    volumeLeft = capacity;
                    wracks++;
                }
            }

            Console.WriteLine(wracks);
        }
    }
}