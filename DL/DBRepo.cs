using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model = Models;
using Entity = DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class DBRepo
    {
        // private Entity.kpopsnapshotdbContext _context;
        // public DBRepo(Entity.kpopsnapshotdbContext context)
        // {
        //     _context = context;
        // }

        // public Model.Customer AddCustomer(Model.Customer custom)
        // {
        //     Entity.Customer customToAdd = new Entity.Customer()
        //     {
        //         Name = custom.Name,
        //         Email = custom.Email,
        //         Address = custom.Address,
        //         Points = custom.Points
        //     };

        //     customToAdd = _context.Add(customToAdd).Entity;
        //     _context.SaveChanges();
        //     _context.ChangeTracker.Clear();

        //     return new Model.Customer()
        //     {
        //         Id = customToAdd.Id,
        //         Name = customToAdd.Name,
        //         Email = customToAdd.Email,
        //         Address = customToAdd.Address,
        //         Points = customToAdd.Points
        //     };
        // }

        // public List<Model.Customer> GetAllCustomers()
        // {
        //     return _context.Customer.Select(
        //         customer => new Model.Customer() {
        //             Id = customer.Id,
        //             Name = customer.Name,
        //             Email = customer.Email,
        //             Address = customer.Address,
        //             Points = customer.Points
        //         }
        //     ).ToList();
        // }

        // public Model.Customer UpdateCustomer(Model.Customer customerToUpdate)
        // {
        //     Entity.Customer customToUpdate = new Entity.Customer() {
        //         Id = customerToUpdate.Id,
        //         Name = customerToUpdate.Name,
        //         Email = customerToUpdate.Email,
        //         Address = customerToUpdate.Address,
        //         Points = customerToUpdate.Points
        //     };

        //     customToUpdate = _context.Customer.Update(customToUpdate).Entity;
        //     _context.SaveChanges();
        //     _context.ChangeTracker.Clear();

        //     return new Model.Customer() {
        //         Id = customToUpdate.Id,
        //         Name = customToUpdate.Name,
        //         Email = customToUpdate.Email,
        //         Address = customToUpdate.Address,
        //         Points = customToUpdate.Points
        //     };
        // }

    }
}
