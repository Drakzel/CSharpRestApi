using CustomerAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppDAL
{
    public interface ICustomerRepository
    {
        Customer Create(Customer cust);

        List<Customer> GetAll();
        Customer Get(int id);

        Customer Delete(int id);
    }
}
