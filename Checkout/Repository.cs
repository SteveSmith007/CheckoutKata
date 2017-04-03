using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Repository : IRepository
    {
        private readonly IList<Sku> _catalogue;
        private readonly IList<MultibuyDiscount> _multibuyDiscounts;

        public Repository()
        {
            _catalogue = new List<Sku>()
            {
                new Sku("A", 50),
                new Sku("B", 30),
                new Sku("C", 20),
                new Sku("D", 15)
            };

            _multibuyDiscounts = new List<MultibuyDiscount>()
            {
                new MultibuyDiscount("A", 3, 20),
                new MultibuyDiscount("B", 2, 15),
            };
        }
        

        public Sku FindSku(string code)
        {
            return _catalogue.FirstOrDefault(s => s.Code == code);
        }

        public IList<MultibuyDiscount> MultibuyDiscounts
        {
            get { return _multibuyDiscounts; }
        }

        public decimal FindPrice(string code)
        {
            return FindSku(code).Price;
        }
    }

    public class Sku
    {
        public Sku(string code, decimal price)
        {
            Code = code;
            Price = price;
        }

        public string Code { get; }
        public decimal Price { get; }
    }

    public class MultibuyDiscount
    {
        public MultibuyDiscount(string sku, int qty, decimal discount)
        {
            Sku = sku;
            Qty = qty;
            Discount = discount;
        }

        public string Sku { get; }
        public int Qty { get; }
        public decimal Discount { get; }
    }
}
