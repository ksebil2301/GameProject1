﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Entities
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Uptade(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
