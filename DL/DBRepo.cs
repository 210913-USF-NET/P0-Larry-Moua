using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class DBRepo : IRepo
    {
        private Entity.kpopsnapshotdbContext _context;

        public DBRepo(Entity.kpopsnapshotdbContext context)
        {
            _context = context;
        }

        public Model.Customer AddCustomer(Model.Customer custom)
        {
            Entity.Customer customToAdd = new Entity.Customer(){
                Name = custom.Name,
                Email = custom.Email,
                Address = custom.Address,
                Points = 0
            };

            customToAdd = _context.Add(customToAdd).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.Customer()
            {
                Id = customToAdd.Id,
                Name = customToAdd.Name,
                Email = customToAdd.Email,
                Address = customToAdd.Address,
                Points = customToAdd.Points
            };

        }

        public Model.Customer UpdateCustomer(Model.Customer customToUpdate)
        {
            throw new NotImplementedException();

        }

        public List<Model.Customer> GetAllCustomers()
        {
            return _context.Customers.Select(
                customers => new Model.Customer()
                {
                    Id = customers.Id,
                    Name = customers.Name,
                    Email = customers.Email,
                    Address = customers.Address,
                    Points = customers.Points
                }
            ).ToList();
        }
    }
}
