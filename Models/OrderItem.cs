﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
    }
}
