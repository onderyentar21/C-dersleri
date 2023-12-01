using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedirKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //oluşturduğumuz oop artık generic tipinde oldu yani artık nesne türettiğimiz clas 
            // artık bir string gibi davranacak ve değişkenler ve methodlar hepsi string olaca
            // string olmasının nedeni çünkü biz veri tipini string gibi <tadık.

            Musteri<String> musteri = new Musteri<String>();

        }
    }
}
