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
            IKrediManager aracKrediManeger = new AracKrediManager();
            IKrediManager konutKrediManeger = new KonutKrediManager();
            IKrediManager esnafKrediManeger = new EsnafKredisiManager();


            //Kredi çesitlerini IKrediManeger türünde bir değişken olarak tanımladık.
            //Bu değişkenler artık ilgili classların referanslarını tutabilir.

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); 
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerServis();

            BasvuruManager basvuruManeger = new BasvuruManager();
            basvuruManeger.BasvuruYap(esnafKrediManeger, smsLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManeger, konutKrediManeger };

            //basvuruManeger.KrediOnBilgilendirme(krediler);


            
           
        }
    }
}
