using Models;
using System.Collections.Generic;

namespace DL
{
    public interface IRepo
    {
        List<Customer> GetAllCustomers();
        Customer AddCustomer(Customer custom);
        Customer UpdateCustomer(Customer customToUpdate, string input);
        List<Inventory> GetAllInventory(int id);
        List<Photocard> GetAllPhotocard();

    }
}