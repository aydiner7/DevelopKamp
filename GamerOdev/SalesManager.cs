using System;
using System.Collections.Generic;
using System.Text;

namespace GamerOdev
{
    class SalesManager : ISalesService
    {

        double islem;
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+game.Price+" karşılığında "+game.Name+" almıştır.");
        }

        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            islem = game.Price - ((game.Price * campaign.DiscountPercent) / 100);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + campaign.Name + "dan " + "%" + campaign.DiscountPercent + " indirim ile " + islem + " karşılığında " + game.Name + " almıştır.");
        }


    }
}
