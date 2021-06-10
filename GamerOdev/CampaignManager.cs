using System;
using System.Collections.Generic;
using System.Text;

namespace GamerOdev
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" Kampanyası Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Düzenlendi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }
    }
}
