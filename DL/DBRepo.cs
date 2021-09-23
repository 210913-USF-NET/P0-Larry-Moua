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

        public Model.Customer AddCustomer(Model.Customer custom)
        {
            throw new NotImplementedException();

        }

        public List<Model.Customer> GetAllCustomers()
        {
            throw new NotImplementedException();

        }

        public Model.Customer UpdateCustomer(Model.Customer customToUpdate)
        {
            throw new NotImplementedException();

        }
    }
}
