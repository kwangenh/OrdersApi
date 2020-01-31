using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Models;

namespace OrdersApi.Contracts
{
    public interface IOrderRepository
    {
        public List<Order> GetOrders();
        public Order GetOrder(int orderId);
        public Order CreateOrder(Order thisOrder);
        public Order DeleteOrder(int orderId);
        public Order EditOrder(Order thisOrder);
    }
}
