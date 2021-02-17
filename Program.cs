using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Musteri musteri2 = new Musteri();

            Musteri[] musteriler = new Musteri[] {musteri, musteri2 };
            MusteriManager islemler = new MusteriManager();

            islemler.MusteriEkle(musteri, musteri2);
            islemler.MusteriListele(musteriler);
            islemler.MusteriSil(musteri);

            Console.WriteLine("\nSecilen musteri silindi.. \n");

            islemler.MusteriListele(musteriler);

        }
    }
}
