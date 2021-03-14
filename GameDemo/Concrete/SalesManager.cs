using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        //Satış
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + game.GameName + " oyununu " + game.GamePrice + " TL'ye satın aldı!" + '\n');
        }
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - ((game.GamePrice * campaign.Discount) / 100);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " - " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile %" + campaign.Discount + " indirimle " + campaignPrice + " TL'ye satın aldı!" + '\n');
        }

        
    }
}
