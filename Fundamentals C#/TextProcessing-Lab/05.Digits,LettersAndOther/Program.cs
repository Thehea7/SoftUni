namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string letters = String.Empty;
            string digits = String.Empty;
            string others = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    letters += input[i];
                    
                }
                else if (char.IsDigit(input[i]))
                {
                    digits += input[i];
                }
                else
                {
                    others += input[i];
                }
            }

            Console.WriteLine($"{digits}\n{letters}\n{others}");
            
        }
    }
}