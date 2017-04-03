using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class CheckoutSingleUnits
    {
        [TestMethod]
        public void OneAGivesTotalOf50()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("A");

            Assert.AreEqual(50M, checkout.Total);
        }

        [TestMethod]
        public void OneBGivesTotalOf30()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("B");

            Assert.AreEqual(30M, checkout.Total);
        }

        [TestMethod]
        public void OneCGivesTotalOf20()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("C");

            Assert.AreEqual(20M, checkout.Total);
        }

        [TestMethod]
        public void OneDGivesTotalOf15()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("D");

            Assert.AreEqual(15M, checkout.Total);
        }
    }
}
