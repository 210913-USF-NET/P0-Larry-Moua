using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Serilog;

namespace Models
{
    public class Customer
    {

        public Customer(string name, string email, string address, int points)
        {

        }

        public int ID { get; set;}

        private string _name;

        public string name
        {
            get { return _name;}
            set
            {
                Regex pattern = new Regex("^[a-zA-Z]+$");

                if(value.Length == 0)
                {
                    InputInvalidException e = new InputInvalidException("Customer name can't be empty");
                    Log.Warning(e.Message);
                    throw e;
                }
                else if(!pattern.IsMatch(value))
                {
                    throw new InputInvalidException("Customer name can only have alphabetical characters.");
                }
                else
                {
                    _name = value;
                }
            }
        }

    }
}
