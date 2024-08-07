using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Utilities.Messages;

namespace InfluencerManagerApp.Models
{

    public abstract class Influencer : IInfluencer
    {
        private readonly List<string> _participations;
        private readonly  string _username= null!;
        private readonly  int _followers;

        protected Influencer(string username, int followers, double engagementRate)
        {
            Username = username;
            Followers = followers;
            EngagementRate = engagementRate;
            _participations = new List<string>();

        }

        public string Username
        {
            get => _username;
            init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.UsernameIsRequired);
                }
                _username = value;
            }
        }

        public int Followers
        {
            get => _followers;
            init
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.FollowersCountNegative);
                }
                _followers = value;
            }
        }

        public double EngagementRate { get; }
        public double Income { get; private set; }
        public IReadOnlyCollection<string> Participations => _participations.AsReadOnly();
        public void EarnFee(double amount)
        {
            Income += amount;
        }

        public void EnrollCampaign(string brand)
        {
            _participations.Add(brand);
        }

        public void EndParticipation(string brand)
        {
            _participations.Remove(brand);
        }

        public virtual int CalculateCampaignPrice()
        {
            return (int)(Followers * EngagementRate);
        }

        public override string ToString()
        {
            return $"{Username} - Followers: {Followers}, Total Income: {Income}";
        }
    }
}
