namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string, int> numbers = new Dictionary<string, int>();

            for (int i = 0; i < entries; i++)
            {
                string number = Console.ReadLine();
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }

            foreach (var (number, occurancies) in numbers)
            {
                if (numbers[number] % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}