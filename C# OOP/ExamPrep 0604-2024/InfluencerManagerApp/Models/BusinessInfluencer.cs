﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class BusinessInfluencer : Influencer
    {
        private const double BiEngagementRate = 3.0;
        private const double Factor = 0.15;
        public BusinessInfluencer(string username, int followers) 
            : base(username, followers, BiEngagementRate)
        {
        }

        public override int CalculateCampaignPrice()
        {
            return (int)(Followers * EngagementRate * Factor);
        }
    }
}
