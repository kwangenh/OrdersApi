using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        public List<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer CreateCustomer(Customer thisCustomer)
        {
            throw new NotImplementedException();
        }

        public Customer DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer EditCustomer(Customer thisCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
