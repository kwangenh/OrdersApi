using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdersApi.Contracts;
using OrdersApi.Models;

namespace OrdersApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly OrdersDb _context;

        public CustomerRepository(OrdersDb context)
        {
            _context = context;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
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
