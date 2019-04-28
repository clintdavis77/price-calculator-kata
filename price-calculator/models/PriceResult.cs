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
            return Subtotal() + Tax() - Discount();
        }

        public Money Tax()
        {
            return Product.Price * TaxRatePercent;
        }

        public Money Discount()
        {
            return Product.Price * DiscountRatePercent;
        }

        public decimal TaxRatePercent { get; set; }
        public decimal DiscountRatePercent { get; set; }
    }
}
