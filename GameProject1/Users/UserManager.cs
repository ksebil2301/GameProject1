using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Users
{
    internal class UserManager : IUserService
    {
        IEDevletService _eDevletService;
        public UserManager (IEDevletService eDevletService)
        {
            this._eDevletService = eDevletService;
        }
        public void Save(User user)
        {
            if (_eDevletService.MernisCheck(user)==true)
            {
                Console.WriteLine(user.Name+" "+user.SurName+" oyuna hoşgeldiniz.");
            }
            else
            {
                Console.WriteLine("Bilgilerinizi tekrar kontrol ediniz.");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine(user.Name + " " + user.SurName + " Lütfen bekleyin. Bilgileriniz güncelleniyor.");
        }
        public void Delete(User user)
        {
            Console.WriteLine(user.Name + " " + user.SurName + " adlı kullanıcı silinmiştir.");
        }

    }
}
