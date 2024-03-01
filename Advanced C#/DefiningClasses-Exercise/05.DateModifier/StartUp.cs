using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier difference = new DateModifier(date1, date2);
            Console.WriteLine(difference.DifferenceInDays);
        }
    }
}