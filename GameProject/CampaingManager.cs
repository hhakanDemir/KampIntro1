using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class CampaingManager : ICampaingService
    {
        public void Anounce(Campaing capaing)
        {
            Console.WriteLine($"Campaing Uygulandı. Oran : {capaing.CampaingRate}");
        }
    }
}
