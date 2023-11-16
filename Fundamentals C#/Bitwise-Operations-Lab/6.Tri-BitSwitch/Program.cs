namespace _6.Tri_BitSwitch
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int threeBitSwitch = 7 <<position;

            input = input ^ threeBitSwitch;
            Console.WriteLine(input);
            
        }
    }
}