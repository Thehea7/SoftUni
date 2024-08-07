using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class BloggerInfluencer : Influencer
    {
        private const double BiEngagementRate = 2.0;
        private const double Factor = 0.2;

        public BloggerInfluencer(string username, int followers) : base(username, followers, BiEngagementRate)
        {
        }

        public override int CalculateCampaignPrice()
        {
            return (int)(Followers * EngagementRate * Factor);
        }
    }
}
