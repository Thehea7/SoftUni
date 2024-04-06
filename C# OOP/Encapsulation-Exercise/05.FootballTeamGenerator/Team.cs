using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private readonly string name;
        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public string Name
        {
            get => name;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public List<Player> Players { get; set; }
        public int Rating
        {
            get
            {
                if (Players.Count == 0)
                {
                    return 0;
                }
                double result = 0;
                Players.ForEach(x => result += x.AverageRating);
                return (int)Math.Round(result / Players.Count, MidpointRounding.AwayFromZero);
            }
        }
        public void Remove(string playerName)
        {
            if (Players.Exists(x => x.Name == playerName) == false)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            Players.RemoveAll(x => x.Name == playerName);
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public override string ToString()
        {
            return $"{Name} - {Rating}";
        }
    }
}
