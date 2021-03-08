using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated.");
        }
    }
}
