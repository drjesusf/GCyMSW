using System;
using System.Collections.Generic;
using Entities;

namespace BusinessLogic
{
    public class CustomerLogic : ICustomerLogic
    {
        public ICollection<Customer> GetCustomers()
        {
            return new List<Customer>{new Customer{CustomerId = 1,FirstName = "Jesus", LastName = "Ramirez"}};
        }

        public Customer GetById(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
