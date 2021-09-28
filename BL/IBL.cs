using Models;
using System.Collections.Generic;
using DL;

namespace RBBL
{
    public interface IBL
    {
        List<Customer> GetAllCustomers();
        Customer AddCustomer(Customer custom);
        Customer UpdateCustomer(Customer customToUpdate, string input);
        List<Inventory> GetAllInventory(int id);
        List<Photocard> GetAllPhotocard();
        Inventory UpdateInventory(Inventory inventoryToUpdate, int input, int input2);
    }
}