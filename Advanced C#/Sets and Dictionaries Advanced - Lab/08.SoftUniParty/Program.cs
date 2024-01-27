namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> reservation = new HashSet<string>();
            string command;

            while ((command = Console.ReadLine()) != "PARTY")
            {
                reservation.Add(command);
            }

            while ((command = Console.ReadLine()) != "END")
            {
                reservation.Remove(command);

            }

            Console.WriteLine(reservation.Count);
            foreach (var invitation in reservation.Where(x => char.IsDigit(x[0])))
            {
                Console.WriteLine(invitation);
            }
            foreach (var invitation in reservation.Where(x => char.IsLetter(x[0])))
            {
                Console.WriteLine(invitation);
            }
        }
    }
}