using CustomerAppBLL.BusinessObjects;
using CustomerAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppBLL.Converters
{
    class CustomerConverter
    {
        internal Customer Convert(CustomerBO cust)
        {
            return new Customer()
            {
                Address = cust.Address,
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                Id = cust.Id
            };
        }

        internal CustomerBO Convert(Customer cust)
        {
            return new CustomerBO()
            {
                Address = cust.Address,
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                Id = cust.Id
            };
        }
    }
}
