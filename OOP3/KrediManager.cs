using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // interface: bir classın imzası gibidir. İçerisinde sadece imzalar olur. Gövde olmaz. I harfi ile başlaması adettendir.
    // Bir class birden fazla interface'i implemente edebilir.
    // Interface'ler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
    //Bu bir nevi kredilerde ne yapılması gerektiğini söyleyen şablon gibi.
    //bir kredi oluşacaksa hesapla, ödemeplanı cıkar, mail at ı yapmalısın demek gibi birsey. 
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
