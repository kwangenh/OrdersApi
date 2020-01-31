using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Models;

namespace OrdersApi.Contracts
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomer();
        public Customer GetCustomer(int customerId);
        public Customer CreateCustomer(Customer thisCustomer);
        public Customer DeleteCustomer(int customerId);
        public Customer EditCustomer(Customer thisCustomer);
    }
}
