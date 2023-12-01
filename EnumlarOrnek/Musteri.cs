using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarOrnek
{
    public class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string lastname { get; set; }
        public string cinsiyet { get; set; }
        public string emailAdress { get; set; }

        public Musteri(int id, string isim, string soyisim, string cinsiyet, string email)
        {
            this.id = id;
            this.isim = isim;
            this.lastname = soyisim;
            this.cinsiyet = cinsiyet;
            this.emailAdress = email;
        }

        public static ArrayList musteriler = new ArrayList();

        // musteri durum burda bir değişken gibidir.
        public MusteriDurum musteriEkle(Musteri m1)
        {
            musteriler.Add(m1);
            // veri tipinden deger tutmak gibi.
            return MusteriDurum.KayitBasarili;

        }
    }
}
