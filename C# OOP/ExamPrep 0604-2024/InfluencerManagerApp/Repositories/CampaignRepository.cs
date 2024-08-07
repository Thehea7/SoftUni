using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories.Contracts;

namespace InfluencerManagerApp.Repositories
{
    public class CampaignRepository : IRepository<ICampaign>
    {
        private readonly List<ICampaign> _models = new();

        public IReadOnlyCollection<ICampaign> Models => _models.AsReadOnly();

        public void AddModel(ICampaign model)
        {
            _models.Add(model);
        }

        public bool RemoveModel(ICampaign model)
        {
            return _models.Remove(model);
        }

        public ICampaign FindByName(string name)
        {
            return _models.FirstOrDefault(c => c.Brand == name);
        }
    }
}
