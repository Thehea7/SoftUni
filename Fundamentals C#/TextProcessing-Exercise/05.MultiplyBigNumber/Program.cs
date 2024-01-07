using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main()
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder output = new StringBuilder();

            int inMind = 0;



            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int result = currentDigit * multiplier + inMind;
                output.Append(result % 10);
                inMind = result / 10;
            }

            if (inMind != 0)
            {
                output.Append(inMind);

            }

            string reversedOutput = new string(output.ToString().ToCharArray().Reverse().ToArray());

            if (reversedOutput.All(x => x == '0'))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(reversedOutput);

            }
        }
    }
}