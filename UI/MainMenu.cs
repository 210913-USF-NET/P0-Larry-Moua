using System;
using Models;
using RBBL;
using DL;

namespace UI
{
    public class MainMenu : IMenu
    {
        public void Start()
        {
            bool exit = false;
            string input = "";
            do
            {
                Console.WriteLine("Welcome to Kpop Snapshot!");
                Console.WriteLine("Please login with your email address or type 'x' to exit.");
                Console.WriteLine("[x] Exit");

                input = Console.ReadLine();

                switch (input)
                {

                    /*
                    case "{email address}
                    // then GO to Customer Menu
                    */

                    case "admin":
                        Console.WriteLine("Welcome Admin!");
                        MenuFactory.GetMenu("admin").Start();
                    break;

                    case "x":
                        Console.WriteLine("Goodbye!");
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