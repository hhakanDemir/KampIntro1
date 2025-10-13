using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IOrderService
    {
        void Order(Order order);
        void Bill();
    }
}
