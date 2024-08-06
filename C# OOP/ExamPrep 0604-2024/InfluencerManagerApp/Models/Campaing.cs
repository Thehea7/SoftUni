using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;

namespace InfluencerManagerApp.Models
{
    public abstract class Campaing : ICampaign
    {

        protected Campaing(string brand, double budget)
        {
            Brand = brand;
            Budget = budget;
        }

        public string Brand { get; }
        public double Budget { get; }
        public IReadOnlyCollection<string> Contributors { get; }
        public void Gain(double amount)
        {
            throw new NotImplementedException();
        }

        public void Engage(IInfluencer influencer)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{nameof(Campaing)} - Brand: {Brand}, Budget: {Budget}, Contributors: {Contributors.Count}";
        }
    }
}
