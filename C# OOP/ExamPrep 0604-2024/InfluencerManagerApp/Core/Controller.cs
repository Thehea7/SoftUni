using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Core.Contracts;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories;
using InfluencerManagerApp.Repositories.Contracts;
using InfluencerManagerApp.Utilities.Messages;

namespace InfluencerManagerApp.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IInfluencer> _influencers = new InfluencerRepository();
        private readonly IRepository<ICampaign> _campaigns = new CampaignRepository();

        public string RegisterInfluencer(string typeName, string username, int followers)
        {
            IInfluencer influencer;
            switch (typeName)
            {
                case nameof(BloggerInfluencer):
                    influencer = new BloggerInfluencer(username, followers);
                    break;
                case nameof(BusinessInfluencer):
                    influencer = new BusinessInfluencer(username, followers);
                    break;
                case nameof(FashionInfluencer):
                    influencer = new FashionInfluencer(username, followers);
                    break;
                default: return string.Format(OutputMessages.InfluencerInvalidType, typeName);
            }

            if (_influencers.FindByName(username) is not null)
            {
                return string.Format(OutputMessages.UsernameIsRegistered, username, nameof(InfluencerRepository));
            }

            _influencers.AddModel(influencer);

            return string.Format(OutputMessages.InfluencerRegisteredSuccessfully, username);
        }

        public string BeginCampaign(string typeName, string brand)
        {
            ICampaign campaign;

            switch (typeName)
            {
                case nameof(ProductCampaign):
                    campaign = new ProductCampaign(brand);
                    break;
                case nameof(ServiceCampaign):
                    campaign = new ServiceCampaign(brand);
                    break;
                default:
                    return string.Format(OutputMessages.CampaignTypeIsNotValid, typeName);
            }

            if (_campaigns.FindByName(brand) is not null)
            {
                return string.Format(OutputMessages.CampaignDuplicated, brand);
            }

            _campaigns.AddModel(campaign);
            return string.Format(OutputMessages.CampaignStartedSuccessfully, brand, typeName);
        }

        public string AttractInfluencer(string brand, string username)
        {
            if (_influencers.FindByName(username) is null)
            {
                return string.Format(OutputMessages.InfluencerNotFound, nameof(InfluencerRepository), username);
            }

            if (_campaigns.FindByName(brand) is null)
            {
                return string.Format(OutputMessages.CampaignNotFound, brand);
            }

            IInfluencer influencer = _influencers.FindByName(username);
            ICampaign campaign = _campaigns.FindByName(brand);

            if (campaign.Contributors.Contains(username))
            {
                return string.Format(OutputMessages.InfluencerAlreadyEngaged, username, brand);
            }

            if ((campaign.GetType().Name == nameof(ProductCampaign) &&
                 influencer.GetType().Name == nameof(BloggerInfluencer))
                || (campaign.GetType().Name == nameof(ServiceCampaign) &&
                    influencer.GetType().Name == nameof(FashionInfluencer)))
            {
                return string.Format(OutputMessages.InfluencerNotEligibleForCampaign, username, brand);
            }

            if (campaign.Budget - influencer.CalculateCampaignPrice() < 0)
            {
                return string.Format(OutputMessages.UnsufficientBudget, brand, username);
            }

            campaign.Engage(influencer);
            influencer.EnrollCampaign(brand);
            influencer.EarnFee(influencer.CalculateCampaignPrice());


            return string.Format(OutputMessages.InfluencerAttractedSuccessfully, username, brand);
        }

         public string FundCampaign(string brand, double amount)
        {
            ICampaign campaign = _campaigns.FindByName(brand);

            if (campaign is null)
            {
                return string.Format(OutputMessages.InvalidCampaignToFund);
            }

            if (amount <= 0)
            {
                return string.Format(OutputMessages.NotPositiveFundingAmount);
            }

            campaign.Gain(amount);
            return string.Format(OutputMessages.CampaignFundedSuccessfully, brand, amount);
        }

        public string CloseCampaign(string brand)
        {
            ICampaign campaign = _campaigns.FindByName(brand);

            if (campaign is null)
            {
                return string.Format(OutputMessages.InvalidCampaignToClose);
            }

            if (campaign.Budget <= 10_000)
            {
                return string.Format(OutputMessages.CampaignCannotBeClosed, brand);
            }

            foreach (var name in campaign.Contributors)
            {
                IInfluencer influencer = _influencers.FindByName(name);
                influencer.EarnFee(2000);
                influencer.EndParticipation(brand);
            }

            _campaigns.RemoveModel(campaign);

            return string.Format(OutputMessages.CampaignClosedSuccessfully, brand);
        }

        public string ConcludeAppContract(string username)
        {
            IInfluencer influencer = _influencers.FindByName(username);

            if (influencer is null)
            {
                return string.Format(OutputMessages.InfluencerNotSigned, username);
            }

            if (influencer.Participations.Any())
            {
                return string.Format(OutputMessages.InfluencerHasActiveParticipations, username);
            }

            _influencers.RemoveModel(influencer);
            return string.Format(OutputMessages.ContractConcludedSuccessfully, username);
        }

        public string ApplicationReport()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var influencer in _influencers.Models
                         .OrderByDescending(i => i.Income)
                         .ThenByDescending(i => i.Followers))
            {
                sb.AppendLine(influencer.ToString());
                if (influencer.Participations.Count > 0)
                {
                    sb.AppendLine("Active Campaigns:");
                    foreach (var campaignName in influencer.Participations.OrderBy(c => c))
                    {
                        ICampaign campaign = _campaigns.FindByName(campaignName);
                        sb.AppendLine($"--{campaign.ToString()}");
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
