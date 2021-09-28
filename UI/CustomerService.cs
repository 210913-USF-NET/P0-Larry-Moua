using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace UI
{
    public class CustomerService
    {
        public Inventory SelectACustomer(string prompt, List<Inventory> listToPick)
        {
            selectCustom:
            Console.WriteLine(prompt);
            for (int i = 0; i < listToPick.Count; i++)
            {
                Console.WriteLine($"[{i}] {listToPick[i]})");
            }
            string input = Console.ReadLine();
            int parsedInput;

            bool parseSuccess = Int32.TryParse(input, out parsedInput);

            if(parseSuccess && parsedInput >= 0 && parsedInput < listToPick.Count)
            {
                return listToPick[parsedInput];
            }
            else {
                Console.WriteLine("invalid input");
                goto selectCustom;
            }
        }
    }
}