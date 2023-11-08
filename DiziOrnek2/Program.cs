using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane int değer alan ve şunları yapan programı kodlayınız...
            // 1- Kaç adet tek , çift eleman olduğunu
            // 2- Çift değerlerin toplamını , Tek değerlerin toplamını
            // 3- Son olarak kontrol yapsın Çift değerlerin toplamı tek değerlerden büyükse Çift değerlerin toplamı büyüktür yazdırsın.
            
             //eğer teklerin toplamı büyükse => tek değerlerin toplamı büyüktür yazdırsın ...

            int[]Sayilar = new int[10];
            int tekadet = 0;
            int ciftAdet = 0;

            int ciftTOplam = 0;
            int tekToplam = 0;
            int deger;


            for(int i=0; i<Sayilar.Length; i++)
            {
                Console.WriteLine((i+0)+".index degerini giriniz :");
                deger=int.Parse(Console.ReadLine());
                Sayilar[i] = deger;

            }
          for(int j =0; j<Sayilar.Length; j++)
            {
                if (Sayilar[j] % 2 == 0)
                {
                    ciftAdet++;
                    ciftTOplam += Sayilar[j];
                }
                else
                {
                    tekadet++;
                    tekToplam += Sayilar[j];
                }
            }
            if (ciftTOplam > tekToplam)
            {
                Console.WriteLine("cift sayilarin toplamı teksayilarin toplamından büyüktür.");

            }
            else
            {
                Console.WriteLine("tek sayilarin toplami cift sayilarin toplamından büyüktür..");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("teksayiları adet : " + tekadet);
            Console.WriteLine("tek sayilari toplam: " + tekToplam);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Cift sayialri adet : "+ciftAdet);
            Console.WriteLine("cift sayilar toplam: " + ciftTOplam);

            Console.ReadLine();
            /*
            int[] sayilar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekSayilarinToplami = 0;
            int ciftSayilarinToplami = 0;

            int kullaniciDeger;


            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i + 0) + ".index değerini giriniz :");
                kullaniciDeger = int.Parse(Console.ReadLine());

                sayilar[i] = kullaniciDeger; // Dizimin içini kullanıcıdan aldığım değerlerle doldurdum...
            }


            for (int j = 0; j < sayilar.Length; j++)
            {

                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    ciftSayilarinToplami += sayilar[j];
                }

                else
                {
                    tekAdetToplam++;
                    tekSayilarinToplami += sayilar[j];
                }

            }

            if (ciftSayilarinToplami > tekSayilarinToplami)
            {
                Console.WriteLine("Çift Sayılarin Toplamı Tek sayiların toplamından Büyüktür");
            }

            else
            {
                Console.WriteLine("Tek Sayılarin Toplamı Çift Sayilarin Toplamından Büyüktür");
            }

            Console.WriteLine("*********************************");

            Console.WriteLine("Çift Sayilarin Toplamı :" + ciftSayilarinToplami);
            Console.WriteLine("Çift Sayilarin Adedi : " + ciftAdetToplam);


            Console.WriteLine("*********************************");

            Console.WriteLine("Tek Sayilarin Toplamı :" + tekSayilarinToplami);
            Console.WriteLine("Tek Sayilarin Adedi :" + tekAdetToplam);

            Console.ReadLine();
            */
        }
    }
}
