﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
  class Program
    {
        static void Main(string[] args)
        {
            // http://bilgidunyasi.info/interface-nedir-ornekli-anlatim-c/

            // Interface'lerden bir tane örnek oluşturamazsınız.
            // Interface'i implement'e eden classdan aldığımız örneği interface karşılayabilir.
            // Interface içerisinde metotları tanımlarız. Classlarda da içeriğini doldururuz.
            // Interface içindeki metotların ERİŞİM BELİRLEYİCİLERİ ve İÇERİĞİ olmaz.
            // Interface leri miras alan sınıflar, içerisinde tanımlanan tüm metodları Implemente etmek zorundadır.
            // Bir Class sadece bir class tan türetebilirken, bir Class birden çok Interface ten türetilebilir.

            IMusteri musteri = new MusteriClass();
            musteri.ekle();
            musteri.sil();

            Console.ReadLine();
        }
    }
}
