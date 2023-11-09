namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());

           PrintSmallestOfThreeNumbers(n1, n2, n3);
        }

        static void PrintSmallestOfThreeNumbers(int n1, int n2, int n3)
        {
            
            if (n1 > n2)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp;
            }

            if (n1 > n3)
            {
                int temp = n1;
                n1 = n3;
                n3 = temp;

            }

            Console.WriteLine(n1);
   
        }
    }
}