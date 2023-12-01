using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    public class MusteriKontroller
    {
      public void Musteriekle(IMusteri veritabani)
        {
            
            veritabani.sil();
            veritabani.ekle();
            veritabani.guncelle();

        }
    }
}
