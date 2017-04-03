using Checkout.Interfaces;

namespace Checkout.Concrete
{
    public class Scanner : IScanner
    {
        private ICheckout _checkout;
        public Scanner(ICheckout checkout)
        {
            _checkout = checkout ?? new Checkout();
        }

        public void Scan(string barcode)
        {
            _checkout.Register(barcode);
        }
    }
}
