using System;
using System.Collections.Generic;

namespace Models
{
    public class Product
    {
        public Product() {}

        public Product(int photocardId, string setName, decimal price) {
            this.photocardId = photocardId;
            this.setName = setName;
            this.price = price;
        }

        public int photocardId {get; set;}
        public string setName {get; set;}
        public decimal price {get; set;}

        public override string ToString()
        {
            return $"SetName: {this.setName} Price: {price}";
        }
    }
}