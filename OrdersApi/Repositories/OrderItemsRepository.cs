using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Repositories
{
    public class OrderItemsRepository : IOrderItemsRepository
    {
        public List<OrderItem> GetOrderItems()
        {
            throw new NotImplementedException();
        }

        public OrderItem GetOrderItem(int orderItemId)
        {
            throw new NotImplementedException();
        }

        public OrderItem CreateOrderItem(OrderItem thisOrderItem)
        {
            throw new NotImplementedException();
        }

        public OrderItem DeleteOrderItem(int orderItemId)
        {
            throw new NotImplementedException();
        }

        public OrderItem EditOrderItem(OrderItem thisOrderItem)
        {
            throw new NotImplementedException();
        }
    }
}
