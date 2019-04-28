using System;
using System.Collections.Generic;
using System.Text;

namespace price_calculator.interfaces
{
    public interface ITaxRate
    {
        IPriceResult WithTaxRate(decimal taxRatePercent);
    }
}
