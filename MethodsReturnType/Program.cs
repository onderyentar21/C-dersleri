using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 12;
        int sayiar =    toplamaYap(5, 7) + a;
            Console.WriteLine("methodtan gelen deger ve benim değişken toplamı : "+sayiar);
            */
            String GelenDeger = IsımSoyIsımDondur("Onder","Yentar");
            Console.WriteLine("Gelen Değerler : " + GelenDeger);

            Console.ReadLine();

        }
        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;

        }

        static String IsımSoyIsımDondur(String isim, String soyisim)
        {
            return isim +" " + soyisim;
            // return değeri döndüren bir anahtar kelimedir.
            // return metodu bitirir. Yani methodtan sonra kodlar çalışmaz bu yüzden method en sona yazılır.
            
        }
    }
}
