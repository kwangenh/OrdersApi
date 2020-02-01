using OrdersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrdersApi.Contracts
{
    public interface IOrderItemsRepository
    {
        public List<OrderItem> GetOrderItems();
        public OrderItem GetOrderItem(int orderItemId);
        public OrderItem CreateOrderItem(OrderItem thisOrderItem);
        public OrderItem DeleteOrderItem(int orderItemId);
        public OrderItem EditOrderItem(OrderItem thisOrderItem);
    }
}
