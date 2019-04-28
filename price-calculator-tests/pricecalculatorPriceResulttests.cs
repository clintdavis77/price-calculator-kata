using System;
using Xunit;
using price_calculator;
using price_calculator.models;
using models;
using NodaMoney;

namespace price_calculator_tests
{
    public class pricecalculatorPriceResulttests
    {
        [Fact]
        public void SubTotal_IsCorrect()
        {
            // arrange
            var product = new Product("Widget", 12345, Money.USDollar(12.35));
            var pr = new PriceResult();
            pr.Product = product;

            // act
            var result = pr.Subtotal();

            // assert
            Assert.True(result == Money.USDollar(12.35));
        }

        [Fact]
        public void Tax_IsCorrect()
        {
            // arrange
            var product = new Product("Widget", 12345, Money.USDollar(12.35));
            var pr = new PriceResult();
            pr.Product = product;
            pr.TaxRatePercent = 0.07M;

            // act
            var result = pr.Tax();

            // assert
            Assert.True(result == Money.USDollar(0.86));
        }

        [Fact]
        public void Total_IsCorrect()
        {
            // arrange
            var product = new Product("Widget", 12345, Money.USDollar(12.35));
            var pr = new PriceResult();
            pr.Product = product;
            pr.TaxRatePercent = 0.07M;

            // act
            var result = pr.Total();

            // assert
            Assert.True(result == Money.USDollar(13.21));
        }

        [Fact]
        public void Discount_IsCorrect()
        {
            // arrange
            var product = new Product("Widget", 12345, Money.USDollar(12.35));
            var pr = new PriceResult();
            pr.Product = product;
            pr.DiscountRatePercent = 0.15M;

            // act
            var result = pr.Discount();

            // assert
            Assert.True(result == Money.USDollar(1.85));
        }

        [Fact]
        public void TotalWithDiscountAndTax_IsCorrect()
        {
            // arrange
            var product = new Product("Widget", 12345, Money.USDollar(20.25));
            var pr = new PriceResult();
            pr.Product = product;
            pr.TaxRatePercent = 0.20M;
            pr.DiscountRatePercent = 0.15M;

            // act

            // assert
            Assert.True(pr.Tax() == Money.USDollar(4.05));
            Assert.True(pr.Discount() == Money.USDollar(3.04));
            Assert.True(pr.Total() == Money.USDollar(21.26));
        }
    }
}
