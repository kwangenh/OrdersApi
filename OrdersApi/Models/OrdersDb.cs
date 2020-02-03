using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Models;

namespace OrdersApi.Models
{
    public class OrdersDb : DbContext
    {
        public OrdersDb(DbContextOptions<OrdersDb> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customer {get;set;}
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<ShipTo> ShipTo { get; set; }
    }
}
