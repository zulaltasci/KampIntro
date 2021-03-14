using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign
    {
        /// <summary>
        /// Kampanya ile ilgili özellikleri tanımladım.
        /// (I have described the proparty about the campaign)
        /// </summary>
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; }
    }
}
