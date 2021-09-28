using System;
using Models;
using RBBL;
using System.Collections.Generic;

namespace UI
{
    public class AdminMenu : IMenu
    {
        private IBL _bl;
        private AdminService _adminService;

        public AdminMenu(IBL bl, AdminService adminService)
        {
            _bl = bl;
            _adminService = adminService;
        }

        public void Start()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Please select an option.");
                Console.WriteLine("[0] Browse Catalog");
                Console.WriteLine("[1] Browse All Customers");
                Console.WriteLine("[2] Browse All Orders");
                Console.WriteLine("[x] Sign Out");

                switch (Console.ReadLine())
                {
                    case "0":
                        ViewCatalog();
                        break;

                    case "1":
                        ViewAllCustomers();
                        break;

                    case "2":
                        ViewAllOrders();
                        break;
                    
                    case "x":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a proper command.");
                        break;
                }

            } while (!exit);
        }

        public void ViewAllCustomers()
        {
            List<Customer> allCustom = _bl.GetAllCustomers();
            foreach (Customer custom in allCustom)
            {
                Console.WriteLine(custom.ToString());
            }
        }

        public void ViewCatalog()
        {
            List<Inventory> allInvent = _bl.GetAllInventory(0);
            foreach (Inventory invent in allInvent)
            {
                Console.WriteLine(invent.ToString());
            }
        }

        public void ViewAllOrders()
        {
            List<Order> allOrd = _bl.GetAllOrders();
            foreach (Order ord in allOrd)
            {
                Console.WriteLine(ord.ToString());
            }
        }
    }
}