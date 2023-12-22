using System.Collections.Generic;

namespace _03.MobaChallenger
{
    class Role
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Role(string name, int points)
        {
            Name = name;
            Points = points;
        }
    }
    class Player
    {
        public string Name { get; set; }

        public int TotalPoints { get; set; }

        public Dictionary<string, Role> Roles { get; set; }

        public Player(string name)
        {
            Name = name;
            Roles = new Dictionary<string, Role>();
        }

        public override string ToString()
        {
            string positions = string.Empty;
            foreach (var role in Roles.Values.OrderByDescending(x => x.Points).ThenBy(x => x.Name))
            {
                positions += $"\n- {role.Name} <::> {role.Points}";
            }

            return $"{Name}: {TotalPoints} skill{positions}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            var players = new Dictionary<string, Player>();

            string command;
            while ((command = Console.ReadLine()) != "Season end")
            {
                if (command.Contains('>'))
                {
                    FillDictionary(players, command);
                }
                else
                {
                    Duel(command, players);
                }
            }

            foreach (var player in players.OrderByDescending(x => x.Value.TotalPoints).ThenBy(x => x.Key))
            {
                Console.WriteLine(player.Value);
            }
        }

        private static void Duel(string command, Dictionary<string, Player> players)
        {
            string[] argumens = command.Split(" vs ");
            string player1 = argumens[0];
            string player2 = argumens[1];
            if (players.ContainsKey(player1) && players.ContainsKey(player2))
            {
                bool haveInCommon = false;
                foreach (var role in players[player1].Roles)
                {
                    if (players[player2].Roles.ContainsKey(role.Key))
                    {
                        haveInCommon = true;
                        break;
                    }
                }

                if (haveInCommon)
                {
                    if (players[player1].TotalPoints > players[player2].TotalPoints)
                    {
                        players.Remove(player2);
                    }
                    else if (players[player1].TotalPoints < players[player2].TotalPoints)
                    {
                        players.Remove(player1);
                    }
                }
            }
        }

        public static void FillDictionary(Dictionary<string, Player> players, string command)
        {
            string[] arguments = command.Split(" -> ");
            string name = arguments[0];
            string role = arguments[1];
            int points = int.Parse(arguments[2]);

            if (!players.ContainsKey(name))
            {
                players.Add(name, new Player(name));
            }

            if (!players[name].Roles.ContainsKey(role))
            {
                players[name].Roles.Add(role, new Role(role, points));
                players[name].TotalPoints += points;
            }

            if (players[name].Roles[role].Points < points)
            {
                players[name].Roles[role].Points = points;
                players[name].TotalPoints -= players[name].Roles[role].Points;
                players[name].TotalPoints += points;
            }

            
        }
    }
}