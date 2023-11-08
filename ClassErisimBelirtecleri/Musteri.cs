using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassErisimBelirtecleri
{
     class Musteri
    {

        public String isim;
        public String soyisim;
        public String cinsiyet;
        public int maas;
        private int yas;

        // constrotor kısa yolu oluşturmak için ctor kullnaırız.
        public Musteri()
        {
            Console.WriteLine("Müşteri sınıfının yapıcı metodu çalıştı...");
            yas = 0;


        }

        public void musteriBilgileriGoster()
        {
            Console.WriteLine("isim : "+isim);
            Console.WriteLine("Soyisim : "+soyisim);
            Console.WriteLine("Cinsiyet: "+cinsiyet);
            Console.WriteLine("Maaş : "+maas);
            Console.WriteLine("Yaşı : "+yas);

        }
        private void IsımSoyisimYazdir(String musteriIsim, String musteriSoyIsım)
        {
            Console.WriteLine("Müşterinin İsim ve Soyisim : "+ musteriIsim+" "+musteriSoyIsım);
        }


    }
}
