using System;
using Models;
using RBBL;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
                        DisplayCustomer.Email = input2;
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
            Console.WriteLine("[2] Change Name");
            Console.WriteLine("[3] View Photocard ID");
            Console.WriteLine("[x] Sign Out");

            input = Console.ReadLine();

                switch(input)
                {
                    case "0":
                        ChangeWarehouse();
                        break;

                    case "1":
                        BrowseWarehouse();
                        break;
                    
                    case "2":
                        ChangeName();
                        break;

                    case "3":
                        CheckSetId();
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

        public void ChangeName()
        {
            Console.WriteLine($"Your name is {DisplayCustomer.Name}. Do you wish to change it?");
            string confirmInput = Console.ReadLine();
            switch(confirmInput)
            {
                case "y":
                    Console.WriteLine("Please input your new name.");
                    string input = Console.ReadLine();
                    Console.WriteLine($"Your new name is {input}!");

                    List<Customer> allCustom = _bl.GetAllCustomers();
                    foreach (Customer custom in allCustom)
                    {
                        if (DisplayCustomer.Email == custom.Email)
                        {
                            custom.Name = input;
                            DisplayCustomer.Name = input;
                            Console.WriteLine(custom.Name);
                            _bl.UpdateCustomer(custom, input);
                        }
                    }
                    break;

                case "n":
                    break;

                default:
                    Console.WriteLine("Please enter [y] or [n] and try again.");
                    break;
            }
        }

        public void ChangeWarehouse()
        {
            bool exit = false;
            string input = "";
            do {
                Console.WriteLine($"You are currently at {DisplayCustomer.Warehouse}.");
                Console.WriteLine("Please select the warehouse you wish to use.");
                Console.WriteLine("[0] WarehouseUS");
                Console.WriteLine("[1] WarehouseDE");
                Console.WriteLine("[2] WarehouseKR");
                Console.WriteLine("[x] Cancel");
                input = Console.ReadLine();

                switch(input)
                {
                    case "0":
                        DisplayCustomer.Warehouse = "WarehouseUS";
                        exit = true;
                        break;

                    case "1":
                        DisplayCustomer.Warehouse = "WarehouseDE";
                        exit = true;
                        break;
                    
                    case "2":
                        DisplayCustomer.Warehouse = "WarehouseKR";
                        exit = true;
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

        public void BrowseWarehouse()
        {
            int id = 0;
            if (DisplayCustomer.Warehouse == "WarehouseUS")
            {
                id = 1;
            } else if (DisplayCustomer.Warehouse == "WarehouseDE")
            {
                id = 2;
            } else if (DisplayCustomer.Warehouse == "WarehouseKR")
            {
                id = 3;
            }

            string setName = "";

            Console.WriteLine($"-----INVENTORY AT {DisplayCustomer.Warehouse}-----");
            List<Photocard> allPhoto = _bl.GetAllPhotocard();
            List<Inventory> allInvent = _bl.GetAllInventory(id);
                foreach (Inventory invent in allInvent)
                {
                    if (id == invent.WarehouseId)
                    {
                        foreach (Photocard photo in allPhoto)
                        {
                            if (invent.PhotocardId == photo.Id)
                            {
                                setName = photo.SetId;
                            }
                        }
                        Console.WriteLine($"Photocard: {setName} PhotocardId: {invent.PhotocardId} Stock: {invent.Stock}");
                    }
                }
        }

        public void CheckSetId()
        {
            Console.WriteLine("Please enter the number of the Photocard ID you wish to view.");
        }
    }
}