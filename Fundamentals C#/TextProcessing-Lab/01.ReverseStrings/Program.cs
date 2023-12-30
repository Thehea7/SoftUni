using System.Text;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main()
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string output = new string(command.Reverse().ToArray());
               Console.WriteLine($"{command} = {output}");
            }

        }
    }
}