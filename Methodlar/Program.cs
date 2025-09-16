using System;
using System.Collections.Generic;
using System.Text;


namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("----------Methodlar--------------");

            SepetManager sepetManager = new SepetManager(); // instance - örnek
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12);
            sepetManager.Ekle2("Elma", "Yesil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12);

        }
    }
}
