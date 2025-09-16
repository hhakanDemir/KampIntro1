using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10; 
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 = ?

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            
            //sayilar1[0] = ?;


            // int, decimal, float, double, boolean => deger tipi
            // array, class, interface => referance tipi

            // deger tipileri RAM de stack hafızada tutulur.

            //sayi1 = 30; deger tipi olduğu için atanan deger sonradan değişmez.
            //sayilar1[0] = 999; referans tipi olduğu için gösterdiği değer değişir.
        }
    }
}
