using GameProject1.GameSale;
using GameProject1.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Entities
{
    public interface IGameSaleService
    {
        void Sale(User user,Game game);
        void CampSale(Game game, Campaign campaign);
       
    }
}
