using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class DBRepo //: IRepo
    {
        private Entity.kpopsnapshotdbContext _context;

        public DBRepo(Entity.kpopsnapshotdbContext context)
        {
            _context = context;
        }

        // public Model.Customer AddCustomer(Model.Customer custom)
        // {
            
        // }

        // public List<Model.Customer> GetAllCustomers()
        // {

        // }

        // public Model.Customer UpdateCustomer(Model.Customer customToUpdate)
        // {

        // }
    }
}
