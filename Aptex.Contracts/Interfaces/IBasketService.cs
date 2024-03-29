﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aptex.Contracts.Models;

namespace Aptex.Contracts.Interfaces
{
    public interface IBasketService : ICrudService<ProductInBasket>
    {
        int ItemsCount(string userId);

        decimal TotalCost(string userId);

        void Clear(string userId);
    }
}
