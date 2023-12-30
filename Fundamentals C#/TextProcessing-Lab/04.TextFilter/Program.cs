namespace _04.TextFilter
{
    internal class Program
    {
        static void Main()
        {
            string[] filters = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var filter in filters)
            {
                while (text.Contains(filter))
                {
                    text = text.Replace(filter, new string('*', filter.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
/*
It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client  
*/