using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    class BaseCampaignManager 
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Campign +" Campaign Added");
        }

    

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Campign + " Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Campign + " Campaign Updated");
        }

       
    }
}
