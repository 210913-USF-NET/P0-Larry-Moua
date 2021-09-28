using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Serilog;

namespace Models
{
    public class Inventory
    {
        public Inventory() {}

        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int PhotocardId { get; set; }
        public int Stock { get; set; }

        public string WarehouseName {get; set;}
        public string Photocard {get; set;}

        public override string ToString()
        {
            return $"Photocard: {this.PhotocardId}, Stock {this.Stock}";
        }
    }
}