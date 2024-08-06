using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class ProductCampaign :Campaing
    {
        private const double PcBudget = 60_000;
        public ProductCampaign(string brand) 
            : base(brand, PcBudget)
        {
        }
    }
}
