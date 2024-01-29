namespace _10.ForceBook
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, HashSet<string>> sides = new Dictionary<string, HashSet<string>>();



            string commands;
            while ((commands = Console.ReadLine()) != "Lumpawaroo")
            {
                if (commands.Contains(" | "))
                {
                    string[] arguments = commands.Split(" | ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    string side = arguments[0];
                    string name = arguments[1];
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new HashSet<string>());
                    }

                    if (NewForceUser(name, sides))
                    {
                        sides[side].Add(name);
                    }

                }
                else
                {
                    string[] arguments = commands.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                    string side = arguments[1];
                    string name = arguments[0];
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new HashSet<string>());
                    }
                    if (NewForceUser(name, sides) || !sides[side].Contains(name))
                    {
                        sides = DeleteUser(name, sides);
                        sides[side].Add(name);

                        Console.WriteLine($"{name} joins the {side} side!");
                    }
                }

            }

            foreach (var (side, names) in sides
                         .OrderByDescending(x => x.Value.Count)
                         .ThenBy(x => x.Key))
            {
                if (names.Count > 0)
                {

                    Console.WriteLine($"Side: {side}, Members: {names.Count}");
                    foreach (var name in names
                                 .OrderBy(x => x))
                    {
                        Console.WriteLine($"! {name}");
                    }
                }
            }


        }

        private static bool NewForceUser(string name, Dictionary<string, HashSet<string>> sides)
        {
            foreach (var side in sides)
            {
                if (side.Value.Contains(name))
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<string, HashSet<string>> DeleteUser(string name, Dictionary<string, HashSet<string>> sides)
        {
            sides = sides.Where(x => !x.Value.Contains(name)).ToDictionary(d => d.Key, d => d.Value);
            return sides;
        }
    }
}

