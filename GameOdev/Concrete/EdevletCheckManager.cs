using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    class EdevletCheckManager : ICheckCustomerService
    {
        public void CheckCustomer(Customer customer)
        {
            Console.WriteLine(customer.Ad+" "+customer.Soyad+" "+"Kişi doğrulandı");
        }
    }
}
