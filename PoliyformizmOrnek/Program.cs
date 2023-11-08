using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliyformizmOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Şekil uygulamasına hoşgeldiniz ..");
            while (true)
            {
                Console.WriteLine("işlem seciniz : ");
                Console.WriteLine("1- dikdörken işlemleri..");
                Console.WriteLine("2- Ucgen işlemleri..");
                Console.WriteLine("3- kare işlemleri..");
                Console.WriteLine("4- q basarak cıkınız.");

                String islem = Console.ReadLine();
                if (islem=="q")
                {
                    break;
                }
                else if (islem=="1")
                {
                    
                    while (true)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("1-dikdorken alan hesapla");
                        Console.WriteLine("2- diktorgen bilgileri goster.");
                        Console.WriteLine("3- dikdorken cıkıs yap");
                        String secinDik = Console.ReadLine();
                        if (secinDik=="1") {
                            Console.WriteLine("");
                            Console.WriteLine("kisa kenari giniriniz: ");
                            int kisakenar= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun Kenari giriniz: ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());

                            Dikdorgen dikdorgen = new Dikdorgen("Dikdorken",kisakenar,uzunKenar);
                            dikdorgen.sekilHesapla();

                        }
                        else if (secinDik=="2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("kisa kenari giniriniz: ");
                            int kisakenar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Uzun Kenari giriniz: ");
                            int uzunKenar = Convert.ToInt32(Console.ReadLine());

                            Dikdorgen dikdorgen = new Dikdorgen("Dikdorken", kisakenar, uzunKenar);
                            dikdorgen.sekilBİlgileriGoster();


                        }
                        else if(secinDik=="3") 
                        {
                            break;



                        }
                    }

                }
                else if (islem=="2")
                {

                    while (true)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("1-ucgen alan hesapla");
                        Console.WriteLine("2- ucgen bilgileri goster.");
                        Console.WriteLine("3- ucgen cıkıs yap");
                        String secimUc = Console.ReadLine();
                        if (secimUc=="1")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("taban kenari giniriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("yükseklik Kenari giriniz: ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());

                            Ucgen ucgen = new Ucgen("Üçgen",taban,yukseklik);
                            ucgen.sekilHesapla();

                        }
                        else if (secimUc=="2")
                        {

                            Console.WriteLine("");
                            Console.WriteLine("taban kenari giniriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("yükseklik Kenari giriniz: ");
                            int yukseklik = Convert.ToInt32(Console.ReadLine());
                            Ucgen ucgen = new Ucgen("Üçgen", taban, yukseklik);
                            ucgen.sekilBİlgileriGoster();


                        }
                        else if(secimUc=="3")
                        {
                            break;
                        }

                    }
                }else if (islem=="3")
                {

                    while (true)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("1-karenin alan hesapla");
                        Console.WriteLine("2- Karenin bilgileri goster.");
                        Console.WriteLine("3- Kareden cıkıs yap");
                        String secimKare = Console.ReadLine();
                        if (secimKare == "1")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("kenar kenari giniriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Kare kare = new Kare("Kare", 10);

                            kare.sekilHesapla();
                        }
                        if(secimKare=="2")
                        {

                            Console.WriteLine("");
                            Console.WriteLine("kenar kenari giniriniz: ");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Kare kare = new Kare("Kare", 10);
                            kare.sekilBİlgileriGoster();
                        }
                        else if (secimKare=="3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("please enter a valid number");
                        }

                    }

                }
            }



            Console.ReadLine();
        }
    }
}
