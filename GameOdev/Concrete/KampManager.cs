using GameOdev.Abstract;
using GameOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameOdev.Concrete
{
    class KampManager : ICampService
    {
        public void Add(Camp camp)
        {
            Console.WriteLine("Kampanya Eklendi" + "\n" + camp.Id+"\n"+camp.Ad + "\n" +camp.KampBaslaTarih + "\n" +camp.KampBitisTarih + "\n");
        }

        public void Delete(Camp camp)
        {
            Console.WriteLine("Kampanya Silindi"+" "+camp.Ad);
        }

        public void Update(Camp camp)
        {
            Console.WriteLine("Kampanya Güncellendi" + " " + camp.Ad);
        }
    }
}
