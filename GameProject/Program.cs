using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());

            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1984,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            Console.WriteLine("--------------------------------------------------");

            Order order = new Order
            {
                OrderId = 1,
                GamerId = 1,
                Price = 100,
                ProductName = "Oyun"
            };


            OrderManager orderManager = new OrderManager();
            orderManager.Order(order);

            Campaing campaing = new Campaing();
            campaing.CampaingRate = 20;

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Anounce(campaing);

        }
    }
}
