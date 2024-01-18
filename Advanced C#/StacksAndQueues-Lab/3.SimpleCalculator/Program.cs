namespace _3.SimpleCalculator
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> input = new Queue<string>(Console.ReadLine().Split());
            string sign = "+";
            int sum = 0;

            while (input.Count != 0)
            {
                string current = input.Dequeue();
                if (current == "+") sign = "+";
                else if(current == "-") sign = "-";
                else
                {
                    if (sign == "+") { sum  += int.Parse(current); }
                    else if (sign == "-") {  sum -= int.Parse(current); }
                }
            }
            Console.WriteLine(sum);
        }
    }
}