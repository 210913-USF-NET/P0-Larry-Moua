using System;
using Models;

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
                //Console.WriteLine("Please login with your email address");
                Console.WriteLine("[x] Exit");

                input = Console.ReadLine();

                switch (input)
                {

                    /*
                    case "{email address}
                    */

                    case "admin":
                        Console.WriteLine("Welcome Admin!");
                        exit = true;
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