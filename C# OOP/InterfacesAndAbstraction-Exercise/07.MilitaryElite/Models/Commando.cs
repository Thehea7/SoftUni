using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;
        }
        public List<Mission> Missions { get; private set; }

        public void CompleteMission(string name)
        {
            Mission mission = Missions.FirstOrDefault(x => x.Name == name);
            mission.Status = "Finished";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Missions:");
            Missions.ForEach(x => sb.AppendLine($"  {x.ToString()}"));

            return sb.ToString().TrimEnd();
        }

        
    }
}
