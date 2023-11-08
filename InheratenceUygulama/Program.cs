using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheratenceUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool deger1 = true;
            while (deger1)
            {
                //calışan, Yazılımcı, Yönetici
                Console.WriteLine("Welcome to Worker Aplication");
                Console.WriteLine("1- yazılımcı işlemleri.");
                Console.WriteLine("2- yönetici işlemleri..");
                Console.WriteLine("çıkış için q'a basınız.");

                String deger = Console.ReadLine();
                switch (deger)
                {
                    case "q":
                        Console.WriteLine("programdan cıkılıyor...");
                        Console.WriteLine("bay bay...");
                        
                        //deger1 = false;
                        break;
                    case "1":
                        Yazilimci yazilimci = new Yazilimci(11,"Onder","Yentar","java,C#");
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("yazilimci işlemi secin: ");
                        Console.WriteLine("1- format at..");
                        Console.WriteLine("2- yazılımcının biligilerini göster.");
                        Console.WriteLine("3- cıkıs için q basın.");
                        String yazilimci_deger= Console.ReadLine();
                        while (true)
                        {

                            if (yazilimci_deger.Equals("q"))
                            {
                                Console.WriteLine("Yazilimci işlemlerinden çıkış yapılıyor.");
                               // deger1=false;
                                break;
                                
                            }else if (yazilimci_deger.Equals("1"))
                            {
                                Console.Write("işletim sistemi giriniz : ");
                                String isietimSistemi = Console.ReadLine();
                                yazilimci.format_at(isietimSistemi);
                                break;
                            }
                            else if (yazilimci_deger.Equals("2"))
                            {
                                yazilimci.bilgileriGoster();
                               break;
                            }
                            else
                            {
                                Console.WriteLine("Lutfen gecerli bir işlem giriniz...");
                                break;
                            }
                     
                        }
                        break;

                       

                    case "2":

                        Yonetici yonetici = new Yonetici(2,"Ilyas","Zarifgil",12);
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("lutfen yapacağınız işlemi seciniz: ");
                        Console.WriteLine("1- zam yap:");
                        Console.WriteLine("2-yoneticinin bilgileri göster.");
                        Console.WriteLine("3- q' a basıp cıkıs yap..");
                        String Ysecim= Console.ReadLine();
                        bool ywhile = true;
                        while(ywhile)
                        {
                            if (Ysecim == "1")
                            {
                                Console.WriteLine("Ne kadar zam yapmak istiyorsunuz : ");
                                int zam = Convert.ToInt32(Console.ReadLine());
                                yonetici.zamYap(zam);
                                break;
                            }
                            else if(Ysecim=="2") {


                                yonetici.bilgileriGoster();
                                break;
                            }
                            else if (Ysecim=="q")
                            {
                                Console.WriteLine("Cıkıs yapılıyor..");
                                Console.WriteLine("cıkıs yapıldı..");
                               // deger1 = false;
                                break;
                            }
                           
                            else
                            {
                                Console.WriteLine("lutfen gecerli bir işlem yapınız..");
                                break;
                            }
                            
                        }
                        break;

                    default:
                        Console.WriteLine("lutfen gecerli bir deger giriniz....");
                     break;

                }
                

            }


            deger1 = false;

            Console.ReadLine();
           
        }
    }
}
