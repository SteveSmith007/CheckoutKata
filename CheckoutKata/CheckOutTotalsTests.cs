using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
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
