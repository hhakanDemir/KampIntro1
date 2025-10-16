using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOrderService
    {

        ICampaingService _campaingService; 

        public IsCampaing(ICampaingService campaingService)
        {
            _campaingService = campaingService;
          
        }
        public void Order(Order order)
        {
            Console.WriteLine("Siparis alındı");
        }
    }
}
