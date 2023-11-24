namespace _06.ListManipulationBasics
{                       
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "Add")
                {
                    input.Add(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Remove")
                {
                    input.Remove(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "RemoveAt")
                {
                    input.RemoveAt(int.Parse(arguments[1]));
                }
                else if (arguments[0] == "Insert")
                {
                    input.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                }
            }

            Console.WriteLine(string.Join(" ", input));
            


        }
    }
}
// 23 1 456 63 32 87 9 32
// Remove 5
// Add 1
// Insert 14 2
// RemoveAt 3
// Add 34
// end
