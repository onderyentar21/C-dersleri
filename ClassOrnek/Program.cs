using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek
{
     class Program
    {
        static void Main(string[] args)
           
        {
            bool kontrol;
           
                Ogrenci ogrenci1 = new Ogrenci(15,"Onder","Yentar",65,70,89,"UCF");

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("ogrenci bul bul programına hoşgeldiniz!!");
           
     
              
            while (kontrol = true)
            {
                Console.WriteLine("1- Öğrenci biliglerini göster..\n" +
                             "2- Öğrenci ortalama göster.....\n" +
                             "3-Öğrencinin okulunu göster..\n" +
                             "4- cıkıs yap...");
                Console.WriteLine("lutfen secim yapınız: ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                    case 2:
                        Console.WriteLine("ogrencinin ortalmaası: " + ogrenci1.ogrenciOrtalamaBul());

                        break;
                    case 3:
                        ogrenci1.okulGetir();
                        break;
                    case 4:
                        Console.WriteLine("cıkıs yapıldı iyi günler...");
                        kontrol = false;
                        break;
                    default:
                        Console.WriteLine("lutfen gecerli bir deger giriniz...");
                        break;
                }      
                



                Console.ReadLine();
            }
        }
    }
}
