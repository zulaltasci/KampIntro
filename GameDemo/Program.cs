using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu Oluşturma
            Gamer gamer1 = new Gamer();
            gamer1.Id = "1";
            gamer1.FirstName = "Yiğit";
            gamer1.LastName = "Nebioğlu";
            gamer1.NationalId = "18899276482";
            gamer1.DateOfBirth = ;

            //Oyuncu Ekleme (Add)
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Add(gamer1);
            //Oyuncu Silme (Delete)
            gamerManager1.Delete(gamer1);
            //Oyuncu Güncelleme (Update)
            gamerManager1.Update(gamer1);

            //Oyun Oluşturma
            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Game 1";
            game1.GamePrice = 100;

            //Oyun Ekleme
            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            //Oyun Silme
            gameManager1.Delete(game1);
            //Oyun Güncelleme
            gameManager1.Update(game1);

            //Kampanya Oluşturma
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Discount 10";
            campaign1.DiscountRate = 10;

            //Kampanya Ekleme
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            //Kampanya Silme
            campaignManager1.Delete(campaign1);
            //Kampanya Güncelleme
            campaignManager1.Update(campaign1);

            //Satış
            SalesManager salesManager = new SalesManager();
            //Normal Satış
            salesManager.Sales(game1, gamer1);
            //Kampanyalı Satış
            salesManager.CampaignSales(game1, gamer1, campaign1);
        }
    }
    
}
