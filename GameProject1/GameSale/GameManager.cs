using GameProject1.Campaigns;
using GameProject1.Entities;
using GameProject1.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.GameSale
{
    public class GameManager : IGameSaleService
    {
        public void CampSale(Game game, Campaign campaign)
        {
            Console.WriteLine(game.GameName+" için "+campaign.CampaignName+" adlı kampanyayı kullanarak "+campaign.Discount+ " kadar indirim kazandınız.");
        }

        public void Sale(User user, Game game)
        {
            Console.WriteLine("Oyun alımı gerçekleşmiştir Sayın "+user.NickName +". Oyuna başlamak için tıklayınız.");
        }

        internal void Sale(UserManager user, Game game1)
        {
            throw new NotImplementedException();
        }
    }
}
