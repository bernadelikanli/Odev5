using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Oyuncu Eklendi" + "\n" + customer.Ad + " " +customer.Soyad);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Oyuncu Silindi" + "\n" + customer.Ad + " " + customer.Soyad);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Oyuncu Güncellendi" + "\n" + customer.Ad + " " + customer.Soyad);
        }
    }
}
