using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ISalesService
    {
        void Sales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
