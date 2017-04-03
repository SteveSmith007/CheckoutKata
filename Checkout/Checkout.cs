using System;
using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout
    {
        private Dictionary<string, decimal> _catalogue;

        public Checkout()
        {
            _catalogue = new Dictionary<string, decimal>()
            {
                {"A", 50},
                {"B", 30}
            };
        }

        public decimal Total
        {
            get { return _total; }
        }

        private decimal _total;
        
        public void Register(string sku)
        {
            _total += _catalogue[sku];
        }

    }
}