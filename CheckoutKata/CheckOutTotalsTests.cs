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
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("A");

            Assert.AreEqual(50M, checkout.Total);
        }

        [TestMethod]
        public void OneBGivesTotalOf30()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("B");

            Assert.AreEqual(30M, checkout.Total);
        }

        [TestMethod]
        public void OneCGivesTotalOf20()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("C");

            Assert.AreEqual(20M, checkout.Total);
        }

        [TestMethod]
        public void OneDGivesTotalOf15()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("D");

            Assert.AreEqual(15M, checkout.Total);
        }
    }
}
