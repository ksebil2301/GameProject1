using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine();
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya tükendi");
        }

        public void Uptade(Campaign campaign)
        {
            Console.WriteLine("Yepyeni bir kampanya ile karşınızdayız");
        }
    }
}
