using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String username = "onderyentar";
            int pin = 2112;
            int bakiye = 1000;

            Console.WriteLine("please enter your username:");
            String username_deger = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            int pin_deger = Convert.ToInt32(Console.ReadLine());
            if (username.Equals(username_deger) && pin.Equals(pin_deger))
            {
                while (true)
                {
                    Console.WriteLine("welcome bankamatik. please choose your selection:" + "" +
                   " 1.Bakiye görüntüleme\n" +
                    "2.Para Cekme\n" +
                    "3.para yatırma\n" +
                    "4. cıkıs yapabilirsiniz...");
                    int seleckt = Convert.ToInt32(Console.ReadLine());
                    if (seleckt == 1)
                    {
                        Console.WriteLine("bakiyeniz: " + bakiye);

                    }
                    else if (seleckt == 2)
                    {
                        Console.WriteLine("please enter amount you wanna take :");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        if (amount <= bakiye)
                        {
                            Console.WriteLine("Kalan bakiyeniz: " + (bakiye - amount));


                        }
                        else
                        {
                            Console.WriteLine("please enter a valid amount!!!");
                        }

                    }
                    else if (seleckt == 3)
                    {
                        Console.WriteLine("please enter you wanna enter money amount: ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("New Bakiye: " + (bakiye + deposit));



                    }
                    else if (seleckt == 4)
                    {
                        Console.WriteLine("Cıkışınız yapılıyor...");
                        Console.WriteLine("Cıkısınız yapıldı güle güle..");


                    }
                    else
                    {
                        Console.WriteLine("please enter a valid selection...");
                        // Console.WriteLine( ); cw yazıp ve entere basarsan otomatik olarak tamamlanacaktır..
                        //crtl+K+D yaparsan kodların düzenlenecektir.
                    }
                }





            }








        }
    }
}
