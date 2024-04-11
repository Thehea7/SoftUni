using _03_Raiding.Models.Interfaces;

namespace _03_Raiding.Factories.Interfaces
{
    public interface IFactory
    {
        IBaseHero CreateHero(string name, string type);
    }
}
