using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class FashionInfluencer : Influencer
    {
        private const double FIEngagementRate = 4.0;
        private const double Factor = 0.1;
        public FashionInfluencer(string username, int followers)
            : base(username, followers, FIEngagementRate)
        {
        }


        public override int CalculateCampaignPrice()
        {
            return (int)(Followers * EngagementRate * Factor);
        }
    }
}
