﻿using System;
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

        public Model.Customer UpdateCustomer(Model.Customer customerToUpdate, string input)
        {
            Entity.Customer customToUpdate = (from c in _context.Customers
                where c.Email == customerToUpdate.Email
                select c)
                .SingleOrDefault();

            customToUpdate.Name = input;
            _context.SaveChanges();
            _context.ChangeTracker.Clear();

            return new Model.Customer() {
                Name = customerToUpdate.Name
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

        public List<Model.Inventory> GetAllInventory(int id)
        {
            return _context.Inventories.Select(
                inventories => new Model.Inventory()
                {
                    Id = inventories.Id,
                    WarehouseId = inventories.WarehouseId,
                    PhotocardId = inventories.PhotocardId,
                    Stock = inventories.Stock
                }
                ).ToList();

        }

        public List<Model.Photocard> GetAllPhotocard()
        {
            return _context.Photocards.Select(
                photocard => new Model.Photocard()
                {
                    Id = photocard.Id,
                    SetId = photocard.SetId,
                    Price = photocard.Price
                }
            ).ToList();
        }
    }
}
