﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
