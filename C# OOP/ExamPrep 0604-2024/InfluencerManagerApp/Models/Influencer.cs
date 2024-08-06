using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;

namespace InfluencerManagerApp.Models
{

    public abstract class Influencer : IInfluencer
    {
        public Influencer(string username, int followers, double engagementRate)
        {
            Username = username;
            Followers = followers;
            EngagementRate = engagementRate;


        }

        public string Username { get; }
        public int Followers { get; }
        public double EngagementRate { get; }
        public double Income { get; }
        public IReadOnlyCollection<string> Participations { get; }
        public void EarnFee(double amount)
        {
            throw new NotImplementedException();
        }

        public void EnrollCampaign(string brand)
        {
            throw new NotImplementedException();
        }

        public void EndParticipation(string brand)
        {
            throw new NotImplementedException();
        }

        public int CalculateCampaignPrice()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Username} - Followers: {Followers}, Total Income: {Income}";
        }
    }
}
