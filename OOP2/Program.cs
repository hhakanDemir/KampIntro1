using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gerçek Müşteri

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //Tüzel Müşteri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "9876543210";

            // Müşteri class'ı hem gerçek müşterinin hem de tüzel müşterinin referansını tutabiliyor.

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManeger = new MusteriManager();
            musteriManeger.Ekle(musteri1);
            musteriManeger.Ekle(musteri2);
        }
    }
}
