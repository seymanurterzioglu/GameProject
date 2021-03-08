using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName+" sold to "+gamer.FirstName+" "+gamer.LastName+" with "+campaign.CampaignDiscount+" discount.");
        }

        public void Sale(Gamer gamer,Game game)
        {
            Console.WriteLine(game.GameName + " sold to " + gamer.FirstName + " " + gamer.LastName );
        }
    }
}
