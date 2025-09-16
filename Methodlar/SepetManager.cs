using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        // naming convention -> methodlar buyuk harfle baslar
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler " + urun.Adi + " sepetinize eklendi!");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);
        }
    }
}
