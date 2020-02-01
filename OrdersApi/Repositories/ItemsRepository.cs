using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        public List<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public Item GetItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public Item CreateItem(Item thisItem)
        {
            throw new NotImplementedException();
        }

        public Item DeleteItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public Item EditItem(Item thisItem)
        {
            throw new NotImplementedException();
        }
    }
}
