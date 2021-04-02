using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
    //new
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);


            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityId),gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }

    }

}


       
