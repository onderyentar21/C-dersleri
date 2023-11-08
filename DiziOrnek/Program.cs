using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayı dizinin içinde var mı ? kontrol eden varsa kaç tane olduğunu söyleyen yoksa da yoktur diye uyarın
            //programı kodlayınız.
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            int adet = 0;
            int sayi;
            Console.WriteLine("Lutfen sayinizi giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i<sayilar.Length;i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
                
            }
            if(adet==0)
            {
                Console.WriteLine("girdiğiniz sayi dizide bulunmamaktadır");

            }
            else
            {
                Console.WriteLine("\"girdiğiniz sayilarin adedi: "+adet);
            }


            Console.ReadLine();


        }
    }
}
