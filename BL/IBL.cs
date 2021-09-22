using Models;
using System.Collections.Generic;
using DL;

namespace RBBL
{
    public interface IBL
    {
        List<Customer> GetAllCustomers();
        Customer AddCustomer(Customer custom);
        Customer UpdateCustomer(Customer customToUpdate);
    }
}