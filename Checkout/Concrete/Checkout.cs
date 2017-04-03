using System.Collections.Generic;
using System.Linq;
using Checkout.Interfaces;

namespace Checkout.Concrete
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
                return _items.Sum(item => _repository.FindSku(item).Price)
                    -_repository.MultibuyDiscounts.Sum(multibuyDiscount => 
                        (_items.Count(i => i.Equals(multibuyDiscount.Sku))/multibuyDiscount.Qty)*multibuyDiscount.Discount);
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