namespace _02.ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int element = int.Parse(arguments[1]);
                

                if (arguments[0] == "Delete")
                {
                    input.RemoveAll(x => x == element);
                }
                else if (arguments[0] == "Insert")
                {
                    int position = int.Parse(arguments[2]);
                    input.Insert(position, element);
                }

            }

            Console.WriteLine(string.Join(" ", input));
            
        }
    }
}