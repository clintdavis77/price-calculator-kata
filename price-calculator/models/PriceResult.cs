using System;
using System.Collections.Generic;
using System.Text;
using models;
using NodaMoney;

namespace price_calculator.models
{
    public class PriceResult
    {
        public Product Product { get; set; } 

        public Money Subtotal()
        {
            return Product.Price;
        }

        public Money Total()
        {
            return Subtotal() + Tax();
        }

        public Money Tax()
        {
            return Product.Price * TaxRatePercent;
        }

        public decimal TaxRatePercent { get; set; }
    }
}
