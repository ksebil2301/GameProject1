using GameProject1.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Entities
{
    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);
    }
}
