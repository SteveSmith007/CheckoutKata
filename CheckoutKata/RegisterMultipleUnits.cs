using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class CheckoutMultipleUnits
    {
        [TestMethod]
        public void TwoAGivesTotalOf100()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(100M, checkout.Total);
        }

        [TestMethod]
        public void ThreeAGivesTotalOf130()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(130M, checkout.Total);
        }

        [TestMethod]
        public void FourAGivesTotalOf180()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");
            checkout.Register("A");

            Assert.AreEqual(180M, checkout.Total);
        }

        [TestMethod]
        public void SixAGivesTotalOf260()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

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
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("A", 6);

            Assert.AreEqual(260M, checkout.Total);
        }

        [TestMethod]
        public void TwoBAtOnceGivesTotalOf45()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("B", 2);

            Assert.AreEqual(45M, checkout.Total);
        }

        [TestMethod]
        public void OneBThenOneAThenOneBGivesTotalOf95()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("B");
            checkout.Register("A");
            checkout.Register("B");

            Assert.AreEqual(95M, checkout.Total);
        }

        [TestMethod]
        public void ComplexTest()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            checkout.Register("A");
            checkout.Register("B");
            checkout.Register("C");
            checkout.Register("D");
            checkout.Register("A", 3);
            checkout.Register("B", 4);

            Assert.AreEqual(335M, checkout.Total);
        }

    }
}
