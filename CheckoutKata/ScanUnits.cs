using Checkout.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutKata
{
    [TestClass]
    public class ScanUnits
    {
        [TestMethod]
        public void ScanOneAGivesTotalOf50()
        {
            var checkout = new Checkout.Concrete.Checkout(new TestRepository());

            var scanner = new Scanner(checkout);

            scanner.Scan("A");

            Assert.AreEqual(50M, checkout.Total);
        }
        
    }
}
