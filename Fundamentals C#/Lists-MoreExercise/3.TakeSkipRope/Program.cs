namespace _3.TakeSkipRope
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<string> text = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber;
                bool isDigit = int.TryParse(input[i].ToString(), out currentNumber);
                if (isDigit)
                {
                    numbers.Add(currentNumber);
                }
                else
                {
                    text.Add(input[i].ToString());
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            List<string> output = new List<string>();

            for (int i = 0; i < takeList.Count; i++)
            {

                int count = 0;
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (j >= text.Count)
                    {
                        break;
                    }
                    output.Add(text[j]);
                    count++;
                }
                text.RemoveRange(0, count);
                count = skipList[i];
                if (count >= text.Count)
                {
                    count = text.Count;
                }
                text.RemoveRange(0, count);
            }

            Console.WriteLine(string.Join("", output));
            
        }
    }
}