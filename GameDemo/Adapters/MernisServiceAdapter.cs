using GameDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.NationaltyId, Ad: gamer.FirstName, Soyad: gamer.LastName, DogumYili: gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
