using CustomerAppBLL.BusinessObjects;
using CustomerAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppBLL
{
    public interface ICustomerService
    {
        CustomerBO Create(CustomerBO cust);

        List<CustomerBO> GetAll();
        CustomerBO Get(int id);

        CustomerBO Update(CustomerBO cust);

        CustomerBO Delete(int id);
    }
}
