using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
        public string NickName { get; set; }
    }
}
