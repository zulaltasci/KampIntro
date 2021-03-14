using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " ismindeki kampanya eklendi!");
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " ismindeki kampanya güncellendi!");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " ismindeki kampanya silindi!");
        }
    }
}
