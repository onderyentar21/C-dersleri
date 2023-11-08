using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tür dönüşümleri konusunu görüyoruz javaya benziyor...
            //dönüşümlerde veri tipinde deger büyükse deger kaybına uğrayabilir.


            //String veri tipinden int veri tipine dönüştürdük.
            //  int a = 500;
            //  byte b = (byte)a;
            //  Console.WriteLine(b.GetType());
            //  Console.WriteLine(b);


            //String sayi1 = "1";

            // String sayi2 = "2";

            // int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);
            //  int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);
            // Console.WriteLine(a+b);

            // İnt veri tipinden String veri tipine dönüştürme
            /*
            int sayi1 = 213;
            int sayi2 = 432;

            String a = sayi1.ToString();
            String b = sayi2.ToString();
            //Console.WriteLine(sayi1+sayi2);
            Console.WriteLine(a + b);
            Console.ReadLine();
            

            //Double veri tipinden int veri tipine dönüştürme
            double sayi = 5.22;

            int a = Convert.ToInt32(sayi);
            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            //  Console.WriteLine(sayi);
            // Console.WriteLine(sayi.GetType());

            //Kullanıcıdan alınan degerler Stringdir.
            Console.WriteLine( "Lütfen yaş değerini giriniz : ");
            String kullanici_yas = Console.ReadLine();
            double yas = Convert.ToDouble(kullanici_yas);

            Console.WriteLine(yas.GetType());
            Console.WriteLine("Yas: "+yas);
            */

            //Kullanıcıdan iki tane sayı alan ve toplamlarını ekrana yazın ?

            Console.WriteLine("Please enter first Number :");
            int first_Nunber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second Number: ");
            int second_Number =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sayıların Toplama: "+(first_Nunber+second_Number));



















            Console.ReadLine();



        }
    }
}
