using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Utilities.Messages;

namespace InfluencerManagerApp.Models
{
    public abstract class Campaign : ICampaign
    {
        private readonly  string _brand;
        private readonly List<string> _contributors;

        protected Campaign(string brand, double budget)
        {
            Brand = brand;
            Budget = budget;
            _contributors = new List<string>();
        }

        public string Brand
        {
            get => _brand;
           init
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandIsrequired);
                }

                _brand = value;
            }
        }

        public double Budget { get; private set; }
        public IReadOnlyCollection<string> Contributors => _contributors.AsReadOnly();

        public void Gain(double amount)
        {
            Budget += amount;
        }

        public void Engage(IInfluencer influencer)
        {
            _contributors.Add(influencer.Username);

            Budget -= influencer.CalculateCampaignPrice();
        }

        public override string ToString()
        {
            return $"{GetType().Name} - Brand: {Brand}, Budget: {Budget}, Contributors: {Contributors.Count}";
        }
    }
}
