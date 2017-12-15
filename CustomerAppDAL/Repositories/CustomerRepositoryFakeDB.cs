using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CustomerAppDAL.Entities;

namespace CustomerAppDAL.Repositories
{
    class CustomerRepositoryFakeDB : ICustomerRepository
    {
        private static int Id = 1;
        private static List<Customer> Customers = new List<Customer>();

        public Customer Create(Customer cust)
        {
            Customer newCust;
            Customers.Add(newCust = new Customer()
            {
                Id = Id++,
                Address = cust.Address,
                FirstName = cust.FirstName,
                LastName = cust.LastName
            });
            return newCust;
        }

        public Customer Delete(int id)
        {
            var customerFound = Get(Id);
            Customers.Remove(customerFound);
            return customerFound;
        }

        public Customer Get(int id)
        {
            var cust = Customers.FirstOrDefault(x => x.Id == Id);
            return cust;
        }

        public List<Customer> GetAll()
        {
            return Customers.ToList();
        }
    }
}
