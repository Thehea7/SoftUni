using _03_Raiding.Factories.Interfaces;
using _03_Raiding.Models;
using _03_Raiding.Models.Interfaces;

namespace _03_Raiding.Factories
{
    public class Factory : IFactory
    {
        public IBaseHero CreateHero(string name, string type)
        {
            switch (type)
            {
                case "Paladin":
                    return new Paladin(name);
                case "Warrior":
                    return new Warrior(name);
                case "Druid":
                    return new Druid(name);
                case "Rogue":
                    return new Rogue(name);
                default:
                    throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
