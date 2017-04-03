using System.Collections.Generic;

namespace Checkout
{
    public interface IRepository
    {
        decimal FindPrice(string code);

        Sku FindSku(string code);

        IList<MultibuyDiscount> MultibuyDiscounts { get; }
    }
}