using GameOdev.Abstract;
using GameOdev.Concrete;
using GameOdev.Entities;
using System;

namespace GameOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Tc = "12345678952";
            customer1.Ad = "Beril";
            customer1.Soyad = "Can";
            customer1.DogumYil = new DateTime(20,2,10);

            Game game1 = new Game();
            game1.Id = 1;
            game1.Ad = "Brawl Stars";
            game1.Fiyat=50;

            Camp camp1 = new Camp();
            camp1.Id = 2;
            camp1.Ad = "Çok al az öde";
            camp1.KampBaslaTarih = new DateTime(20, 5, 6);
            camp1.KampBitisTarih = new DateTime(20, 5, 9);

            ICustomerService costumerManager = new CustomerManager();
            costumerManager.Add(customer1);
            Console.WriteLine("\n"+"---------------");

            ICheckCustomerService eDevletCheckManager = new EdevletCheckManager();
            eDevletCheckManager.CheckCustomer(customer1);
            Console.WriteLine("\n" + "---------------");

            ICampService campManager = new KampManager();
            campManager.Add(camp1);
            campManager.Delete(camp1);
            campManager.Update(camp1);
            Console.WriteLine("\n" + "---------------");

            ISaleService saleManager = new SalesManager();
            saleManager.BuyGame( customer1,  game1,camp1);
            Console.WriteLine("\n" + "---------------");

        }
    }
}
