using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikClassNedir
{
    internal class Musteri
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public String cinsiyet { get; set; }
        public String email { get; set; }
        public DateTime doguntarihi { get; set; }
        public override string ToString()
        {
            return $"Id: {id}, Isim: {isim}, Soyisim: {soyisim},/n" +
                $" Cinsiyet: {cinsiyet}, Email: {email}, Doğum Tarihi: {doguntarihi.ToShortDateString()}";
        }




    }
}
