using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOrderService
    {
        ICampanyServis _campanyServis;

        public OrderManager(ICampanyServis campanyServis) 
        {
            _campanyServis = campanyServis;
        }
        public void Bill()
        {
            throw new NotImplementedException();
        }

        public void Order(Order order)
        {
            Console.WriteLine("satis yapildi");            
        }
    }
}
