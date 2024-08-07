using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;

namespace InfluencerManagerApp.Repositories
{
    public class InfluencerRepository :IRepository<IInfluencer>
    {
        private readonly List<IInfluencer> _models = new();

        public IReadOnlyCollection<IInfluencer> Models => _models.AsReadOnly();

        public void AddModel(IInfluencer model)
        {
            _models.Add(model);
        }

        public bool RemoveModel(IInfluencer model)
        {
           return _models.Remove(model);
        }

        public IInfluencer FindByName(string name)
        {
            return _models.FirstOrDefault(i => i.Username == name);
        }
    }
}
