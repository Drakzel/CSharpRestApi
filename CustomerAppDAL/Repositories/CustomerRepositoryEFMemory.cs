using System;
using System.Collections.Generic;
using System.Text;
using CustomerAppDAL.Context;
using System.Linq;
using CustomerAppDAL.Entities;

namespace CustomerAppDAL.Repositories
{
    class CustomerRepositoryEFMemory : ICustomerRepository
    {
        InMemoryContext context;

        public CustomerRepositoryEFMemory (InMemoryContext context)
        {
            this.context = context;
        }

        public Customer Create(Customer cust)
        {
            context.Customers.Add(cust);
            return cust;
        }

        public Customer Delete(int id)
        {
            var customerFound = Get(id);
            context.Customers.Remove(customerFound);
            return customerFound;
        }

        public Customer Get(int id)
        {
            var cust = context.Customers.FirstOrDefault(x => x.Id == id);
            return cust;
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
    }
}
