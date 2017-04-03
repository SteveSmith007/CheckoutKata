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
