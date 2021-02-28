using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class ApplyCampaign :  Games
    {
       public void applyCampaign(Games games)
        {
            Console.WriteLine("Discounted price of the game : " + ( games.Price-(games.Price*25/100)));
        }
    }
}
