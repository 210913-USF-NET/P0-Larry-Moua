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
                Console.WriteLine("[x] Sign Out");

                switch (Console.ReadLine())
                {
                    case "0":
                        break;

                    case "1":
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


    }
}