namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isValid = true;
            bool isLenghtValid = CheckLenght(input);
            bool isFormatValid = CheckIsDigitOrLetter(input);
            bool isDigitsCountValid = CheckIFMoreThan2Digits(input);

            if (isDigitsCountValid && isLenghtValid && isFormatValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        private static bool CheckLenght(string? input)
        {
            bool isValid = true;
            if (input.Length < 6 || input.Length > 10)
            {
                
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
        
            return isValid;
        }
        private static bool CheckIsDigitOrLetter(string? input)
        {
            bool isValid = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]))
                {
                    isValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;  
                }
            }

            return isValid;
        }

        private static bool CheckIFMoreThan2Digits(string? input)
        {
            int count = 0;
            bool isValid = false;
            foreach (var t in input)
            {
                if (char.IsDigit(t))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        
            return isValid;
        }
    }
}