using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMethodKullanimi
{
    class Kullanici
    {
        private int KullaniciId { get; set; }
        private String isim { get; set; }
        private String soyisim { get; set; }
        private static int maas { get; set; }


        //c# ta statik consktor vardır javada yoktur
        // clastan nesne türettiğimiz zaman new den son ilk başta static yapıcı methoda gider
        //sonra diğerine gider.
        /*
         * Static yapic metoda iliskin dikkat edilmesi gereken bir takim kurallar da vardir. Bu kurallara göre;
         • Static yapic metod erisim belirleyicisi (access modifiers) kullanamaz.
         • Static yapic metod parametre alamaziar.
          • Static yapic metod sinifa ait tüm yapicilardan önce calisir.
         • Static yapic metod kaç nesne örnegi olusturulursa olusturulsun bir kere calisir.
          • Bir sinif sadece bir static yapic metod içerebilir.
          • Static yapic metod ya ilk nesne örnegi olusturuldugunda ya da ilk static sinif yesi caginimadan hemen önce
           yürütülür.
         */

        static Kullanici()
        {
            maas = 8600;

        }

        public Kullanici(int kullaniciid, String isim, string soyisim)
        {
            this.KullaniciId = kullaniciid;
            this.isim = isim;
            this.soyisim = soyisim;


        }
        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı biligleri: ");
            Console.WriteLine("ID : " + KullaniciId);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Maaş: " + maas);
        }
        public void zamYap(int zamMiktar)
        {

            Console.WriteLine("Zam Yapiliyor....");
            Console.WriteLine("Şu anki Maaşı: " + (maas + zamMiktar));
        }
    }
}
