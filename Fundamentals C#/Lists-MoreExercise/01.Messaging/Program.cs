namespace _01.Messaging
{
    internal class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input2 = Console.ReadLine();

            List<string> text = new List<string>();

            for (int i = 0; i < input2.Length; i++)
            {
                text.Add(input2[i].ToString());
            }

            string output = String.Empty;
            for (int i = 0; i < input.Count; i++)
            {
                int currentnumber = input[i];
                int sum = 0;
                while (currentnumber > 0)
                {
                    int digit = currentnumber % 10;
                    sum += digit;
                    currentnumber /= 10;
                }

                if (sum >= text.Count)
                {
                    output += text[sum % text.Count];
                    text.RemoveAt(sum % text.Count);
                }
                else
                {
                    output += text[sum];
                    text.RemoveAt(sum);
                }
            }

            Console.WriteLine(output);




        }
    }
}