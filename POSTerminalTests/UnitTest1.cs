using System;
using Xunit;
using POSTerminal;
using System.Collections.Generic;

namespace POSTerminalTests
{
    public class UnitTest1
    {
        public static int total = 0;

        [Theory]
        [InlineData(1, 4.00, 4.00)]
        [InlineData(4, 3.29, 13.16)]
        [InlineData(11, .96, 10.56)]
        [InlineData(0, 4.85, 0.00)]
        public void lineTotalTests(int quantity, decimal price, decimal entrytotal)
        {
            Checkout testcart = new Checkout();
            Assert.Equal(entrytotal, testcart.lineTotal(quantity, price));

        }
        [Theory]
        [InlineData("Hot Tea", 45, 45)]
        
        public void addToCartTests(string item, int quantity, int expected)
        {
            Checkout test = new Checkout();
            Checkout.cart.Clear();
            //Assert.Equal(expected, Checkout.addToCart(item, quantity));//changed the method to not return a value
        }

        [Theory]
        [InlineData(5.23, 5.60)]
        [InlineData(162.32, 173.68)]
        [InlineData(1, 1.07)]
        [InlineData(0, 0.00)]
        [InlineData(90.00, 96.30)]
        public void grandTotalTests(decimal total, decimal totalPlusTax)
        {
            Assert.Equal(totalPlusTax, Checkout.grandTotal(total));
        }
        [Theory]
        [InlineData("Baked Good", 5, 17.50)]
        [InlineData("Hot Tea", 3, 21.37)]
        [InlineData("New Hardcover Book", 1, 51.36)]
        [InlineData("Wasting Cashier's Time", 1, 51.65)]
        public void subTotalTests(string item, int quantity, decimal expected)
        {
            Checkout.addToCart(item, quantity);
            Assert.Equal(expected, Checkout.subTotal());
        }
        [Theory]
        [InlineData(21.02, 1.47)]
        [InlineData(0, 0.00)]
        [InlineData(41.97, 2.94)]
        [InlineData(145.3, 10.17)]
        [InlineData(1, 0.07)]
        public void salestaxTests(decimal total, decimal expected)
        {
            Assert.Equal(expected, Checkout.salestax(total));
        }
    }
}
