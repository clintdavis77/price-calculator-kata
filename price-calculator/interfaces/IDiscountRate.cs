using System;
using System.Collections.Generic;
using System.Text;
using price_calculator.models;

namespace price_calculator.interfaces
{
    public interface IDiscountRate
    {
        ITaxRate WithDiscountRate(decimal discountRatePercent);
        PriceResult GetResult();
    }
}
