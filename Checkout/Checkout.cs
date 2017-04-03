using System;

namespace CheckoutKata
{
    public class Checkout
    {
        public decimal Total
        {
            get { return _total; }
        }

        private decimal _total;

        public void Register(string sku)
        {
            if (string.Equals("A", sku, StringComparison.InvariantCultureIgnoreCase))
                _total += 50;

            if (string.Equals("B", sku, StringComparison.InvariantCultureIgnoreCase))
                _total += 30;
        }


    }
}