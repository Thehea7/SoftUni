using System.Threading.Channels;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            CheckTypeAndPrint(type, input1, input2);
        }

        private static void CheckTypeAndPrint(string? type, string? input1, string? input2)
        {
            if (type == "int")
            {
                int output = GetMax(int.Parse(input1), int.Parse(input2));
                Console.WriteLine(output);
            }
            else if (type == "char")
            {
                int output = GetMax((int)char.Parse(input1), (int)char.Parse(input2));
                Console.WriteLine((char)output);
            }
            else if (type == "string")
            {
                GetMax(input1, input2);
            }
        }

        private static void GetMax(string? input1, string? input2)
        {
            for (int i = 0, j = 0; i < input1.Length && j < input2.Length; i++, j++)
            {
                if (input1[i] > input2[j])
                {
                    Console.WriteLine(input1);
                    break;
                }
                else if (input1[i] < input2[j])
                {
                    Console.WriteLine(input2);
                    break;
                }
            }
        }

        private static int GetMax(int input1, int input2)
        {
            return input1 > input2 ? input1 : input2;
        }
    }
}

