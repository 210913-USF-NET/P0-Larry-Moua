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
            bool exit = false;
            string input2 = "";
            
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
                        Console.WriteLine("Log in successful! Welcome back!");
                        exit = true;
                        break;
                    } else
                    {
                        Console.WriteLine("Email does not match our records. Please try again or sign up.");
                        exit = true;
                    }
                }
            } while (!exit);
        }

    }
}