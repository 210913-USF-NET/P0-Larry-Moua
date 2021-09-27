using System;
using Models;
using System.Collections.Generic;
using DL;

namespace RBBL
{
    public class BL : IBL
    {
        private IRepo _repo;

        public BL(IRepo repo)
        {
            _repo = repo;
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public Customer AddCustomer(Customer custom)
        {
            return _repo.AddCustomer(custom);
        }

        public Customer UpdateCustomer(Customer customToUpdate, string input)
        {
            return _repo.UpdateCustomer(customToUpdate, input);
        }
    }
}
