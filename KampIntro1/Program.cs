using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemGirisYapilmisMi = true;

            if (sistemGirisYapilmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayar Butonu"); 
            }
            else
            {
                Console.WriteLine("Giris Butonu");
            }

                Console.WriteLine(kategoriEtiketi);
        }
    }
}
