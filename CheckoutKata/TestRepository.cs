using System.Collections.Generic;
using System.Linq;
using Checkout.Interfaces;
using Checkout.Models;

namespace CheckoutKata
{
    public class TestRepository : IRepository
    {
        private readonly IList<Sku> _catalogue;

        public TestRepository()
        {
            _catalogue = new List<Sku>()
            {
                new Sku("A", 50),
                new Sku("B", 30),
                new Sku("C", 20),
                new Sku("D", 15)
            };

            MultibuyDiscounts = new List<MultibuyDiscount>()
            {
                new MultibuyDiscount("A", 3, 20),
                new MultibuyDiscount("B", 2, 15),
            };
        }


        public Sku FindSku(string code)
        {
            return _catalogue.FirstOrDefault(s => s.Code == code);
        }

        public IList<MultibuyDiscount> MultibuyDiscounts { get; }

        public decimal FindPrice(string code)
        {
            return FindSku(code).Price;
        }
    }
}
