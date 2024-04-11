using _03_Raiding.Core.Interfaces;
using _03_Raiding.Factories.Interfaces;
using _03_Raiding.IO.Interfaces;
using _03_Raiding.Models;
using _03_Raiding.Models.Interfaces;

namespace _03_Raiding.Core
{
    public class Engine :IEngine
    {

        private IReader reader;
        private IWriter writer;
        private IFactory heroFactory;
        public Engine(IReader reader, IWriter writer, IFactory heroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroFactory = heroFactory;
        }
        
        public void Run()
        {
            List<IBaseHero> raid = new List<IBaseHero>();
            int n = int.Parse(reader.ReadLine());
            while (raid.Count < n)
            {
                try
                {
                    raid.Add(GetHero());
                }
                catch (ArgumentException e)
                {
                    writer.WriteLine(e.Message);
                }
                
            }

            int bossHealth = int.Parse(reader.ReadLine());
            int raidPower = 0;
            foreach (var baseHero in raid)
            {
                raidPower += baseHero.Power;
               writer.WriteLine(baseHero.CastAbility()); 
            }

            if (raidPower >= bossHealth)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }

        

        private IBaseHero GetHero()
        {
            string name = reader.ReadLine();
            string type = reader.ReadLine();
           return  heroFactory.CreateHero(name, type);
        }
    }
}
