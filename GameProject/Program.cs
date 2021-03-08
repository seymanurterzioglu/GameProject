using System;
using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Adapters;
 

/*
 *Gereksinimler

1.     Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4.     Satışlarda kampanya entegrasyonunu simule ediniz.
*/

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());    

            Gamer gamer = new Gamer   //gamer information
            {
                Id = 1,
                FirstName = "Şeyma Nur",
                LastName = "Terzioğlu",
                NationalityId = "12345",
                BirthYear = 1998
            };

            gamerManager.Add(gamer);      //GamerManager's method used 
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Game game = new Game    //game information
            { 
                GameId=1,
                GameName= "Attack on Titan / A.O.T. Wings of Freedom",
                GamePrice="170TL"
            }; 

            Campaign campaign = new Campaign    //campaign information
            { 
                CampaignId=1,
                CampaignName="8 Mart Kadınlar Günü Kampanyası",
                CampaignDiscount="%40"
            };

            SaleManager saleManager = new SaleManager();

            saleManager.Sale(gamer ,game);                  //SaleManager 's method used
            saleManager.CampaignSale(gamer,game,campaign);

        }
    }
}
