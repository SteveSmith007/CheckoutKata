using System;
using System.Collections.Generic;
using System.Linq;
using Checkout;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly IRepository _repository;

        public Checkout(IRepository repository = null)
        {
            _items = new List<string>();
            _repository = repository ?? new Repository();
        }

        public decimal Total
        {
            get
            {
                var subTotal = _items.Sum(item => _repository.FindPrice(item));

                var discount = 0;

                discount += (_items.Count(i => i.Equals("A")) / 3) * 20;
                discount += (_items.Count(i => i.Equals("B")) / 2) * 15;

                return subTotal - discount;
            }
        }

        private readonly IList<string> _items;

        public void Register(string code, int qty = 1)
        {
            for (var i = 1; i <= qty; i++)
                _items.Add(code);
        }
    }
}