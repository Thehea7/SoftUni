using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class ServiceCampaign : Campaing
    {
        private const double ScBudget = 30_000;

        public ServiceCampaign(string brand) : base(brand, ScBudget)
        {
        }
    }
}
