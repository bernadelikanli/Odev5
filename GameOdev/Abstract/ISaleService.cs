using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface ISaleService
    {
        void BuyGame(Customer customer, Game game,Camp camp);
    }
}
