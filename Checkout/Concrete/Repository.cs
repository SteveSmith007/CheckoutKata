using System;
using System.Collections.Generic;
using Checkout.Interfaces;
using Checkout.Models;

namespace Checkout.Concrete
{
    public class Repository : IRepository
    {
        public decimal FindPrice(string code)
        {
            throw new NotImplementedException();
        }

        public Sku FindSku(string code)
        {
            throw new NotImplementedException();
        }

        public IList<MultibuyDiscount> MultibuyDiscounts { get; }
    }
}
