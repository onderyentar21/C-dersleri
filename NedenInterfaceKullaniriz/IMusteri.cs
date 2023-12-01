using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedenInterfaceKullaniriz
{
    public interface IMusteri
    {
        string Name { get; }
        void ekle();
        void sil();
        void guncelle();

    }
}
