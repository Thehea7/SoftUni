namespace _2.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int output = VowelsCount(input);
            Console.WriteLine(output);

        }

        static int VowelsCount(string input)
        {
            int vowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A' || input[i] == 'o' || input[i] == 'O' || input[i] ==
                        'u' || input[i] == 'U' || input[i] == 'e' || input[i] == 'E' || input[i] == 'i' || input[i] == 'I')
                {
                    vowels++;
                }

            }

            return vowels;
        }
    }
}