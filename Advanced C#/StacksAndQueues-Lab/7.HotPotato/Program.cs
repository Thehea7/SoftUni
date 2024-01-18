namespace _7.HotPotato
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
            int potato = int.Parse(Console.ReadLine());
            int count = 0;
            while (kids.Count > 1)
            {
                count++;
                string name = kids.Dequeue();
                if (count == potato)
                {
                    Console.WriteLine($"Removed {name}");
                    count = 0;
                }
                else
                {
                    kids.Enqueue(name);
                }
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}