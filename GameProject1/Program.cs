using GameProject1.GameSale;
using GameProject1.Users;
using System;

namespace GameProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EDevletManager());
            userManager.Save(new User { Id = 1,NickName="MET", Name = "METİN", SurName = "ERARSLAN", NationalityId = 51145479916, DateOfBirth = new DateTime(1989, 9, 23) });

            Game game1 = new Game
            {
                GameName = "Sudoku",
                GameId = 1,
                Price = 9.99
            };
            Game game2 = new Game
            {
                GameName = "Kelimelik",
                GameId = 2,
                Price = 29.99
            };
            Campaign campaign = new Campaign
            {
                CampaignName="10. Seviye Bonusu",
                CampaignId=1,
                Discount=0.10
            };
            Campaign campaign1 = new Campaign
            {
                CampaignName = "30. Seviye Bonusu",
                CampaignId = 2,
                Discount = 0.25
            };
            GameManager gameManager = new GameManager();
            gameManager.Sale(user: new User(), game2);

            GameManager gameManager1 = new GameManager();
            gameManager1.CampSale(game1, campaign1);




        }
    }
}
