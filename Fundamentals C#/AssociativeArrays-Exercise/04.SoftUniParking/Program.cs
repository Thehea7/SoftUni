using System.Reflection.Metadata;

namespace _04.SoftUniParking
{
    class User
    {
        public User(string name, string licence)
        {
            Name = name;
            LicencePlate = licence;
        }
        public string Name { get; set; }

        public string LicencePlate { get; set; }

        public override string ToString()
        {
            return $"{Name} => {LicencePlate}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, User> usersMap = new Dictionary<string, User>();

            int inputCount = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < inputCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[1];

                if (command[0] == "register")
                {
                    if (!usersMap.ContainsKey(name))
                    {
                        User user = new User(name, command[2]);
                        usersMap.Add(name, user);
                        Console.WriteLine($"{name} registered {command[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (!usersMap.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        usersMap.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var user in usersMap)
            {
                Console.WriteLine(user.Value);
            }
        }
    }
}