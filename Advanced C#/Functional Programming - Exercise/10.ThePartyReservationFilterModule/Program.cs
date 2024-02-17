namespace _10.ThePartyReservationFilterModule
{
    class Guest
    {
        public Guest(string name, bool isFiltered)
        {
            Name = name;
            IsFiltered = isFiltered;
        }
        public string Name { get; set; }
        public bool IsFiltered { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    internal class Program
    {
        static void Main()
        {
            List<Guest> guestList = new List<Guest>();
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var name in input)
            {
                guestList.Add(new Guest(name, false));
            }

            string command;
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] arguments = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string filterType = arguments[0];
                string condition = arguments[1];
                string argument = arguments[2];

                Func<string, bool> predicate = CreateFilter(condition, argument);

                guestList = ApplyFilters(guestList, predicate, filterType);
            }

            Console.WriteLine(string.Join(" ", guestList.Where(x => x.IsFiltered == false)));
            

        }

        private static List<Guest> ApplyFilters(List<Guest> guestlist,  Func<string, bool> predicate, string filterType)
        {
            
            if (filterType == "Add filter")
            {
                foreach (var guest in guestlist)
                {
                    if (predicate(guest.Name))
                    {
                        guest.IsFiltered = true;
                    }
                }
            }

            if (filterType == "Remove filter")
            {
                foreach (var guest in guestlist)
                {
                    if (predicate(guest.Name))
                    {
                        guest.IsFiltered = false;
                    }
                }
            }

            return guestlist;
        }

        private static Func<string, bool> CreateFilter(string condition, string argument)
        {
            if (condition == "Starts with")
            {
                return x => x.StartsWith(argument);
            }
            if(condition == "Ends with")
            {
                return x => x.EndsWith(argument);
            }

            if (condition == "length")
            {
                return x => x.Length == int.Parse(argument);
            }

            if (condition == "Contains")
            {
                return x => x.Contains(argument);
            }

            return null;
        }
    }
}