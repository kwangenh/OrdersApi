using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Order CreateOrder(Order thisOrder)
        {
            throw new NotImplementedException();
        }

        public Order DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Order EditOrder(Order thisOrder)
        {
            throw new NotImplementedException();
        }
    }
}
