using System;
using models;
using price_calculator;
using price_calculator.models;
using NodaMoney;


namespace price_calculator_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("The Little Prince", 12345, Money.USDollar(20.25));

            Console.WriteLine("---1. TAX---");
            Console.WriteLine("");
            
            var result = PriceCalculator.ForProduct(product).WithTaxRate(0.20M).GetResult();

            Console.WriteLine($"Product price reported as {result.Subtotal()} before tax and {result.Total()} after {String.Format("{0:0%}", result.TaxRatePercent)} tax.");

            result = PriceCalculator.ForProduct(product).WithTaxRate(0.21M).GetResult();

            Console.WriteLine($"Product price reported as {result.Subtotal()} before tax and {result.Total()} after {String.Format("{0:0%}", result.TaxRatePercent)} tax.");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("---2. DISCOUNT---");
            Console.WriteLine("");

            result = PriceCalculator.ForProduct(product).WithTaxRate(0.2M).WithDiscountRate(0.15M).GetResult();

            Console.WriteLine($"Tax amount = {result.Tax()}; Discount amount = {result.Discount()}");
            Console.WriteLine($"Price before = {result.Subtotal()}, price after = {result.Total()}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadKey();

            
        }
    }
}
