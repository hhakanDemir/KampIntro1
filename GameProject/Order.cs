﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int GamerId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

    }
}
