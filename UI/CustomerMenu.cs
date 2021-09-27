using System;
using Models;
using RBBL;
using System.Collections.Generic;

namespace UI
{
    public class CustomerMenu : IMenu
    {
        private IBL _bl;
        private CustomerService _customerService;

        public CustomerMenu(IBL bl, CustomerService customerService)
        {
            _bl = bl;
            _customerService = customerService;
        }

        public void Start()
        {
            if (CustomerLogin() == true)
            {
                CustomerMainMenu();
            }
        }

        public bool CustomerLogin()
        {
            bool exit = false;
            string input2 = "";
            bool success = false;
            
            do
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Please log in with your email address.");

                input2 = Console.ReadLine();

                Console.WriteLine("--------------------");
                Console.WriteLine("Loading...");
                Console.WriteLine("--------------------");

                List<Customer> allCustom = _bl.GetAllCustomers();
                foreach (Customer custom in allCustom)
                {
                    if (input2 == custom.EmailLogin())
                    {
                        DisplayCustomer.Name = custom.Name;
                        DisplayCustomer.Warehouse = "WarehouseUS";
                        Console.WriteLine($"Log in successful! Welcome back {DisplayCustomer.Name}!");
                        success = true;
                        exit = true;
                    }
                }

                if (exit == false)
                {
                    Console.WriteLine("Email does not match our records. Please try again or sign up for an account.");
                    exit = true;
                    break;
                }

            } while (!exit);

            return success;
        }

        public void CustomerMainMenu()
        {
            bool exit = false;
            string input = "";

            do{
            Console.WriteLine("--------------------");
            Console.WriteLine($"Welcome {DisplayCustomer.Name}!");
            Console.WriteLine($"You are currently at {DisplayCustomer.Warehouse}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Please select an option.");
            Console.WriteLine("[0] Change Warehouse");
            Console.WriteLine("[1] Browse Catalog");
            Console.WriteLine("[x] Sign Out");

            input = Console.ReadLine();

            switch(input)
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