using Microsoft.VisualBasic;

namespace _07.TheV_Logger
{
    class Vlogger
    {
        public Vlogger(string name)
        {
            Followers = new List<string>();
            Name = name;
        }

        public List<string> Followers { get; set; }
        public int Following { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Followers.Count} followers, {Following} following";
        }
    }

    internal class Program
    {
        static void Main()
        {

            Dictionary<string, Vlogger> vLogger = new Dictionary<string, Vlogger>();
            string commands;

            while ((commands = Console.ReadLine()) != "Statistics")
            {
                string[] arguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = arguments[0];
                string command = arguments[1];

                if (command == "joined" && !vLogger.ContainsKey(name))
                {
                    vLogger.Add(name, new Vlogger(name));
                }
                else if (command == "followed")
                {
                    string nameBeingFollowed = arguments[2];
                    if (IsValid(vLogger, name, nameBeingFollowed))
                    {
                        vLogger[nameBeingFollowed].Followers.Add(name);
                        vLogger[name].Following++;
                    }
                }
            }
            int count = 0;
            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");
            foreach (var (name, vlogger) in vLogger
                         .OrderByDescending(x => x.Value.Followers.Count)
                         .ThenBy(x => x.Value.Following))   
            {
                Console.WriteLine($"{++count}. {vlogger}");
                if (count == 1)
                {
                    foreach (var follower in vlogger.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }

        }
        private static bool IsValid(Dictionary<string, Vlogger> vLogger, string name, string nameBeingFollowed)
        {
            if (!vLogger.ContainsKey(nameBeingFollowed) 
                || !vLogger.ContainsKey(name)
                || name == nameBeingFollowed
                || vLogger[nameBeingFollowed].Followers.Contains(name))
                return false;

            return true;
        }
    }
}