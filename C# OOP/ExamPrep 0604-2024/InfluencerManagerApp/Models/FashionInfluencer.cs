using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class FashionInfluencer : Influencer
    {
        private const double FIEngagementRate = 3.0;
        public FashionInfluencer(string username, int followers)
            : base(username, followers, FIEngagementRate)
        {
        }
    }
}
