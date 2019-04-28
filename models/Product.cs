using System;
using NodaMoney;

namespace models
{
    public class Product
    {
        public string Name { get; private set; }
        public int UPC { get; private set; }
        public Money Price { get; private set; }

        public Product() { }
        public Product(string name, int upc, Money price)
        {
            Name = name;
            UPC = upc;
            Price = price;
        }
    }
}
