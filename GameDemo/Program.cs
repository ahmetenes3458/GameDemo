using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Concrete;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gereksinim 1 

            BaseGamerManager gamersManager = new GameManager(new MernisServiceAdapter());
            gamersManager.Save(new Gamer { DateOfBirth=new DateTime(2001,7,9),FirstName="Ahmet Enes",LastName="Polat",NationaltyId=41722970912 });

            //Gereksinim 2 

            Gamer gamer = new Gamer();
            gamer.FirstName = "Ahmet Enes";
            gamer.LastName = "Polat";
            Games games = new Games();
            games.Name = "Fifa 21";
            games.Id = 1;
            games.Price = 259;
            GameSales gameSales1 = new GameSales();
            gameSales1.Sale(games,gamer);

            //Gereksinim 3

            Campaign campaign = new Campaign();
            campaign.Campign = "% 25";
            campaign.Add(campaign);

            //Gereksinim 4
            ApplyCampaign applyCampaign = new ApplyCampaign();
            applyCampaign.applyCampaign(games);

        }
    }
}
