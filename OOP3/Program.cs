using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        // interfaceler onu implement eden classın referansını tutabilir.
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManeger = new IhtiyacKrediManager();
            ihtiyacKrediManeger.Hesapla();

            IKrediManager tasitKrediManeger = new TasitKrediManager();
            tasitKrediManeger.Hesapla();

            IKrediManager konutKrediManeger = new KonutKrediManager();
            konutKrediManeger.Hesapla();
        }
    }
}
