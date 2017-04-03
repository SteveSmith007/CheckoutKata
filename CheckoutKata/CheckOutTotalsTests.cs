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
    }
}
