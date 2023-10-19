using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input "s3cr3t!P@ssw0rd". "s3cr3t!P@ssw0rd"."Wrong password!".
            string pass = Console.ReadLine();
            //condition

            if (pass == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
