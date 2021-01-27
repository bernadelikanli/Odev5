using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    public interface ICampService
    {
        void Add(Camp camp);
        void Update(Camp camp);
        void Delete(Camp camp);
    }

}

