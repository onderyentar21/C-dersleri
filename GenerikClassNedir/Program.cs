using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
                     List<Musteri> musterilerim  = repositoryMusteri.Getir();
            Musteri musteri = new Musteri();
            musteri.id = 12;
            musteri.isim = "onder";
            musteri.soyisim = "Yentar";
            musteri.cinsiyet = "erkek";
            musteri.email = "onder@gmail.com";
            musteri.doguntarihi = new DateTime(2000,12,12);

            repositoryMusteri.ekle(musteri);

            Repository<Urun> repositoryUrun = new Repository<Urun>();
            List<Urun> urunlerim = repositoryUrun.Getir();

            Urun urun = new Urun();
            urun.urunid =1;
            urun.urunismi = "ram bellek";
            urun.urunfiyat = 200;
        String deger   =  repositoryUrun.ekle(urun);


            Console.WriteLine(deger);
            Console.ReadLine(); 





        }
    }
}
