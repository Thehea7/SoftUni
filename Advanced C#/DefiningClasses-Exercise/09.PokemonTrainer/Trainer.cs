using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    { 
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }= new List<Pokemon>();

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
            Pokemons = pokemons;
        }

        public void ExecuteCommand(string command)
        {
            if (Pokemons.Exists(x => x.Element == command))
            {
                Badges++;
            }
            else
            {
                Pokemons.ForEach(x => x.Health -=10);
                Pokemons.RemoveAll(x => x.Health <= 0);
            }
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
