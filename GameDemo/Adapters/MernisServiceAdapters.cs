using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    class MernisServiceAdapters
    {
        public class MernisServiceAdapter : IUserValidationService
        {
            public bool CheckIfRealPerson(Gamer gamer)
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                var result = client.TCKimlikNoDogrulaAsync(gamer.NationalId, gamer.FirstName, gamer.LastName, gamer.DateOfBirth).Result;
                return result.Body.TCKimlikNoDogrulaResult;
            }
        }
    }
}
