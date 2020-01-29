using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<ShipTo> ShipTos { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
