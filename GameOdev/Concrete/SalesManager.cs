using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    class SalesManager : ISaleService
    {
       

        public void BuyGame(Customer customer, Game game, Camp camp)
        {
            Console.WriteLine("Müşteri Bilgileri" + "\n" + customer.Tc + customer.Ad + " " + customer.Soyad + customer.DogumYil);

            Console.WriteLine("Oyun Bilgisi" + "\n" + "Oyun Adı: " + game.Ad + "\n" + "Oyun Fiyatı: " + game.Fiyat);

            Console.WriteLine("Kampanya Bilgileri" + "Kampanya Adı: " + camp.Ad + "\n" + "Başlama Tarihi: " + camp.KampBaslaTarih + "\n" + "Bitiş Tarihi: " + camp.KampBitisTarih);
        }
    }
}
