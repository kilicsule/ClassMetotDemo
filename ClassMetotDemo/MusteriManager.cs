using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : " + musteri.Adi + "\n----------\n");
        }

        public void Listele(Musteri[] musteriler)
        {

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
            }

            Console.WriteLine("\n---------\n");
        }

        public void Sil(int id)
        {
            Console.WriteLine("Musteri Silindi \n-----------\n");
        }
    }
}
