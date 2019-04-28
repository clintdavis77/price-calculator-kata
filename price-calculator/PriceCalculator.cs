using models;
using System;
using price_calculator.interfaces;
using price_calculator.models;

namespace price_calculator
{
    public sealed class PriceCalculator : ITaxOrDiscountRate, ITaxRate, IDiscountRate
    {
        //private Product _product;
        private PriceResult _priceResult = new PriceResult();

        private PriceCalculator(Product product)
        {
            _priceResult.Product = product;
        }

        public static ITaxOrDiscountRate ForProduct(Product product) => new PriceCalculator(product);

        public IDiscountRate WithTaxRate(decimal taxRatePercent)
        {
            _priceResult.TaxRatePercent = taxRatePercent;
            return this;
        }
 
        public PriceResult GetResult()
        {
            return _priceResult;
        }

        public ITaxRate WithDiscountRate(decimal discountRatePercent)
        {
            _priceResult.DiscountRatePercent = discountRatePercent;
            return this;
        }
    }
}
