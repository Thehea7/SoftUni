using InfluencerManagerApp.Core;
using InfluencerManagerApp.Core.Contracts;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;

namespace InfluencerManagerApp
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();

            //IInfluencer influencer = new BloggerInfluencer("Gosho", 15);
            //Console.WriteLine(influencer);
            //influencer.EnrollCampaign("Super");

            //foreach (var a in influencer.Participations)
            //{
            //    Console.WriteLine(a);
            //}



        }
    }
}
