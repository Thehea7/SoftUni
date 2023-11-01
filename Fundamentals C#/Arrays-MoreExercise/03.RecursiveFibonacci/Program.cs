namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
         
            int[] fibunachiPrime = { 0, 0, 1 };
             
            for (int i = 1; i <= input; i++)
            {
                int[] fibunachi = new int[3];
                fibunachi[0] = fibunachiPrime[1];
                fibunachi[1] = fibunachiPrime[2];
                fibunachi[2] = fibunachi[0] + fibunachi[1];

                fibunachiPrime[0] = fibunachi[0];
                fibunachiPrime[1] = fibunachi[1];
                fibunachiPrime[2] = fibunachi[2];
                
            }
            Console.WriteLine(fibunachiPrime[1]);
        }
    }
}