namespace _5.MultiplicationSign
{
    internal class Program
    {
        static void Main()
        {
            int negativeCount = 0;
            int input = default;
            string output = default;
            for (int i = 0; i < 3; i++)
            {
                 input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    output = "zero";
                }
                else if (input < 0)
                {
                    negativeCount++;
                }
            }

            if (output == "zero")
            {
                Console.WriteLine("zero");
            }
            else if (negativeCount % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            
        }
    }
}