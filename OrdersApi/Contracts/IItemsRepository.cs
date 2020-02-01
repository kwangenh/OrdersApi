using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Models;

namespace OrdersApi.Contracts
{
    public interface IItemsRepository
    {
        public List<Item> GetItems();
        public Item GetItem(int itemId);
        public Item CreateItem(Item thisItem);
        public Item DeleteItem(int itemId);
        public Item EditItem(Item thisItem);
    }
}
