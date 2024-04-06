using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private enum Skills : int
        {
            Endurance,
            Sprint,
            Dribble,
            Passing,
            Shooting
        }
        private readonly string name;
		private readonly List<int> stats;

        public Player(string name, List<int> stats)
        {
            Name = name;
            Stats = stats;
        }
        public List<int> Stats
		{
			get => stats;
            init
            {
                if (value.Any(x => x is < 0 or > 100))
                {
                    int x = value.FindIndex(stat => stat is < 0 or > 100);
                    throw new ArgumentException($"{(Skills)x} should be between 0 and 100.");
                }
                stats = value;
            }
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
        public double AverageRating => stats.Average();
	}
}
