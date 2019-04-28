using System;
using System.Collections.Generic;
using System.Text;
using price_calculator.models;

namespace price_calculator.interfaces
{
    public interface ITaxOrDiscountRate
    {
        ITaxRate WithDiscountRate(decimal discountRatePercent);
        PriceResult GetResult();
        IDiscountRate WithTaxRate(decimal taxRatePercent);
    }
}
