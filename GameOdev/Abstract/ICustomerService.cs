using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Abstract
{
    interface ICustomerService
    {
     
            public void Add(Customer customer);
            public void Update(Customer customer);
            public void Delete(Customer customer);
    }





}
