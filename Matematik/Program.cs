using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(2, 4);
            dortIslem.Topla(1, 3);
            dortIslem.Topla(6, 2);
        }
    }
}
