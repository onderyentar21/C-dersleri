using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisUygulmasi
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int haksayisi = 3;
            while (true) {

                Console.WriteLine("Kullanici Adinizi giriniz : ");
                String kullaniciAdi = Console.ReadLine();

                Console.WriteLine("lütfen sifrenizi giriniz:");
                int sifre = Convert.ToInt32(Console.ReadLine());

                if (kullaniciAdi == "onder"&& sifre ==21412) {
                    Console.WriteLine("Tebrikler basarili bir sekilde giris yaptınız. ");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanci veya sifreniz hatalı.");
                    if (haksayisi>0)
                    {
                        haksayisi -= 1;

                    }
                    if (haksayisi==0) {
                        Console.WriteLine("Hak sayiniz dolmustur giris yapamasınız.");
                        break;

                    }
                }
            
            }

            Console.ReadLine();
        }
    }
}
