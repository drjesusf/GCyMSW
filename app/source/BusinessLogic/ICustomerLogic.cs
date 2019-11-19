using System.Collections.Generic;
using Entities;

namespace BusinessLogic
{
    public interface ICustomerLogic
    {
        ICollection<Customer> GetCustomers();
        Customer GetById(int customerId);

    }
}
