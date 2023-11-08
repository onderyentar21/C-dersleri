using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mini ATM Uygulaması yapalım kullanıcıdan bir değer alalım aldığımız değere göre işlemler yapalım(Switch - Case) kullanıcaz.
            // 1- Bakiye görüntüle
            // 2- Para çek
            // 3- Para Yatır
            // 4- Çıkış yap 
            // 1-2-3-4 dışında bir değer girilmiş ise Hata versin.

            int bakiye = 700;

            Console.WriteLine("Atm ye hoşgeldiniz...");

            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Çek");
            Console.WriteLine("3- Para Yatır");
            Console.WriteLine("4 Çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    Console.WriteLine("Bakiyeniz :" + bakiye);
                    Console.ReadLine();
                    break;


                case "2":

                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz :" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":

                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni Bakiyeniz :" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;
                case "4":

                    Console.WriteLine("Hesabınızdan çıkış yapılıyor İyi Günler");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    Console.ReadLine();
                    break;




            }

        }
    }
}
 