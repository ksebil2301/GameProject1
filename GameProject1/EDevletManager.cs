using GameProject1.Entities;
using GameProject1.Users;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    internal class EDevletManager : IEDevletService
    {
        public bool MernisCheck(User user)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(user.NationalityId, user.Name,user.SurName, user.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
