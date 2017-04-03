using System;
using System.Collections.Generic;
using Checkout;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly IRepository _repository;

        public Checkout(IRepository repository = null)
        {
            _repository = repository ?? new Repository();
        }

        public decimal Total
        {
            get { return _total; }
        }

        private decimal _total;

        public void Register(string code)
        {
            _total += _repository.FindPrice(code);
        }
    }
}