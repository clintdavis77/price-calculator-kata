using System;
using System.Collections.Generic;
using System.Text;
using price_calculator.models;

namespace price_calculator.interfaces
{
    public interface IPriceResult
    {
        PriceResult GetResult();
    }
}
