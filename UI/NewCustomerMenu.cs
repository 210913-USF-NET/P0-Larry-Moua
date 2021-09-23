using System;
using Models;
using RBBL;
using System.Collections.Generic;

namespace UI
{
    public class NewCustomerMenu : IMenu
    {
        private IBL _bl;
        private NewCustomerService _newCustomerService;

        public NewCustomerMenu(IBL bl, NewCustomerService newCustomerService)
        {
            _bl = bl;
            _newCustomerService = newCustomerService;
        }

        public void Start()
        {
            bool exit = false;
            string input = "";
            string newName = "";
            string newEmail = "";
            string newAddress = "";
            do
            {
                userInput:
                Console.WriteLine("--------------------");
                Console.WriteLine("Please enter the following.");
                Console.WriteLine("FULL NAME");
                Console.WriteLine("EMAIL");
                Console.WriteLine("ADDRESS");

                newName = Console.ReadLine();
                newEmail = Console.ReadLine();
                newAddress = Console.ReadLine();

                confirm:
                Console.WriteLine("--------------------");
                Console.WriteLine($"NAME: {newName}");
                Console.WriteLine($"EMAIL: {newEmail}");
                Console.WriteLine($"ADDRESS: {newAddress}");
                Console.WriteLine("Is this correct?");

                input = Console.ReadLine();

                switch(input){
                    case "y":
                        // run AddCustomer()
                        Console.WriteLine("New user created! Please log in with your email address.");
                        exit = true;
                    break;
                    
                    case "n":
                        exit = true;
                        goto userInput;

                    default:
                        Console.WriteLine("Please enter y or n");
                        goto confirm;
                }
            } while (!exit);
        }
    }
}