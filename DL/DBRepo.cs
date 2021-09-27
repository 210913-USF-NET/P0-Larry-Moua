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

        public Model.Customer UpdateCustomer(Model.Customer customerToUpdate)
        {
            Entity.Customer customToUpdate = new Entity.Customer() {
                Id = customerToUpdate.Id,
                Name = customerToUpdate.Name,
                Email = customerToUpdate.Email,
                Address = customerToUpdate.Address,
                Points = customerToUpdate.Points
            };

            customToUpdate = _context.Customers.Update(customToUpdate).Entity;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.Customer() {
                Id = customToUpdate.Id,
                Name = customToUpdate.Name,
                Email = customToUpdate.Email,
                Address = customToUpdate.Address,
                Points = customerToUpdate.Points
            };
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
