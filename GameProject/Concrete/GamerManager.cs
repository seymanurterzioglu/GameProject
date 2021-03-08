using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }


        public void Add(Gamer gamer)
        {
            if(_gamerCheckService.CheckIfRealPerson(gamer)==true)
            {
                Console.WriteLine("The add has been completed successfully.");
            }
            else
            {
                Console.WriteLine("Add failed.Your access is incorrect.");
            }


        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("The delete has been completed successfully.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The update has been completed successfully.");
        }
    }
}
