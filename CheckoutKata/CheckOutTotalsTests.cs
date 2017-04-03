using System;
using CheckoutKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKataTests
{
    [TestClass]
    public class CheckOutTotalsTests
    {
        [TestMethod]
        public void OneAGivesTotalOf50()
        {
            var checkout = new Checkout();

            checkout.Register("A");

            Assert.AreEqual(50M, checkout.Total);
        }

        [TestMethod]
        public void OneBGivesTotalOf30()
        {
            var checkout = new Checkout();

            checkout.Register("B");

            Assert.AreEqual(30M, checkout.Total);
        }
    }
}
