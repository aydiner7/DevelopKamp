using System;

namespace GamerOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                FirstName = "Hasan",
                LastName="AYDINER",
                BirthYear="1995"
            };

            Game game = new Game()
            {
                Name = "Fifa 21",
                Price = 120
            };

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Name = "Black Friday",
                DiscountPercent = 25
            };

            GamerManager gamerManager = new GamerManager(new FacebookControlManager());
            gamerManager.Add(gamer);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer, game, campaign);

            salesManager.Sales(gamer, game);

        }
    }
}
