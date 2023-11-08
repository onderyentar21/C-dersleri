using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Onder");
            koleksiyon.Add("Ergin");
            koleksiyon.Add("Mahir");
            koleksiyon.Add("Tahir");
            //bir diziyi silmek için
            //   koleksiyon.Remove("Ergin");
            // count koleksiyonun içindeki degerleri toplar.
            // int count = koleksiyon.Count;
            //dizi tmamamen temzilemek için ise 
            //  koleksiyon.Clear();
            // dizide aradığımız elemanın olup olmadığını bulmak için contains methodu kullanılır
            // bool kontrol =   koleksiyon.Contains("Onder");
            // indexOf metodu ise aradığım isim kacıncı indexte yani kacıncı sırada olduğunu bana gösterir.
            // eğer değer -1 dönerse bu c# ta böyle bir deger yok demektir.
            // değerleirn arasına deger eklemek için ınsert methodu kullanılır.
            // basta eklediğin sayı bu indexin numarası olacak.
            // reverse(); ise asağıdan yukarıya oku demek yani ters cevir demek.

            //koleksiyon.Insert(2, "Damlanur");

           // int index = koleksiyon.IndexOf("Onder");
          // koleksiyon.Reverse();

            foreach (String isimler in koleksiyon)
            {
                Console.WriteLine(isimler);
            }
            //  Console.WriteLine("Dizinin eleman sayisi: "+count);
            // Console.WriteLine("Var mı : "+kontrol);

            //Console.WriteLine("sırası: "+ index);
            /*

            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(4);
            rakamlar.Add(1);
            rakamlar.Add(54);
            rakamlar.Add(12);
            // Arayliste kücükten büyüğe sıralayan bir method var bunun ismi sort()
            rakamlar.Sort();

            foreach(int a in rakamlar)
            {
                Console.WriteLine("sayilar:"+a);
            }
            */

            // toString() degerleri string veri tipine dönüştürür.
            
            int sayi = 12;

          String deger=  sayi.ToString();


            Console.ReadLine();
        }
    }
}
