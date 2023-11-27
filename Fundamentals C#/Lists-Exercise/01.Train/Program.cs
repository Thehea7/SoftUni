namespace _01.Train
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "Add")
                {
                    input.Add(int.Parse(arguments[1]));
                }
                else
                {
                    FindPlaceForPassangers(input,  capacity, arguments[0]);
                }

            }

            Console.WriteLine(string.Join(" ", input));
            

            


        }

        private static void FindPlaceForPassangers(List<int> input, int capacity, string argument)
        {
            int people = int.Parse(argument);

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] + people <= capacity)
                {
                    input[i] += people;
                    break;
                }
            }
        }
    }
}