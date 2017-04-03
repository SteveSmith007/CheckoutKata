using System;
using CheckoutKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKataTests
{
    [TestClass]
    public class CheckoutMultipleUnits
    {
        [TestMethod]
        public void TwoAGivesTotalOf100()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(130M, checkout.Total);
        }

        [TestMethod]
        public void ThreeAGivesTotalOf130()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(130M, checkout.Total);
        }

        [TestMethod]
        public void FourAGivesTotalOf180()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(180M, checkout.Total);
        }

        [TestMethod]
        public void SixAGivesTotalOf260()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(260M, checkout.Total);
        }

        [TestMethod]
        public void SixAAtOnceGivesTotalOf260()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("A", 6);

            Assert.AreEqual(260M, checkout.Total);
        }

        [TestMethod]
        public void TwoBAtOnceGivesTotalOf45()
        {
            var checkout = new CheckoutKata.Checkout();

            checkout.Register("B", 2);

            Assert.AreEqual(45M, checkout.Total);
        }

    }
}
