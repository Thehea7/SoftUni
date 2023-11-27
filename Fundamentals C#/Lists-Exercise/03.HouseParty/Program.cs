namespace _03.HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string guestName = command[0];

                if (command[2] == "going!")
                {
                    GuestIsGoing(guestList, guestName);
                }
                else if (command[2] == "not")
                {
                    GuestIsNotGoing(guestList, guestName);
                }

            }

            Console.WriteLine(string.Join("\n", guestList));
            
        }

        private static void GuestIsNotGoing(List<string> list, string name)
        {
            if (list.Contains(name))
            {
                list.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }

        private static void GuestIsGoing(List<string> guestList, string guestName)
        {
            if (guestList.Contains(guestName))
            {
                Console.WriteLine($"{guestName} is already in the list!");
            }
            else { guestList.Add(guestName); }
        }
    }
}