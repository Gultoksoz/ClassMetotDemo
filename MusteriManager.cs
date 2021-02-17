using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri eklemusteri, Musteri eklemusteri2)
        {
            eklemusteri.Ad = "Gül";
            eklemusteri.Soyad = "Toksöz";
            eklemusteri.Id = "74185296345";
            eklemusteri.Maas = 5000;
            eklemusteri.MaxKredi = (eklemusteri.Maas / 4);

            eklemusteri2.Ad = "Kerem";
            eklemusteri2.Soyad = "Alaşan";
            eklemusteri2.Id = "74185753945";
            eklemusteri2.Maas = 4500;
            eklemusteri2.MaxKredi = (eklemusteri2.Maas / 5);
        }

        public void MusteriListele(Musteri[] musteriler )
        {
            foreach (var listemusteri in musteriler)
            {
                if(listemusteri.Id == "")
                {
                    continue;
                }
                Console.WriteLine("Musteri id : " + listemusteri.Id);
                Console.WriteLine("Musteri ad : " + listemusteri.Ad);
                Console.WriteLine("Musteri soyad : " + listemusteri.Soyad);
                Console.WriteLine("Musteri maas : " + listemusteri.Maas);
                Console.WriteLine("Musteri max kredi : " + listemusteri.MaxKredi);
                Console.WriteLine("-----*-----");

            }
            Console.WriteLine("Musteriler Bitti");
        }

        public void MusteriSil(Musteri silmusteri)
        {
            silmusteri.Id = "";
            silmusteri.Ad = "";
            silmusteri.Soyad = "";
            silmusteri.Maas = 0;
            silmusteri.MaxKredi = 0;
        }
    }
}
