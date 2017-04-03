using System.Collections.Generic;
using Checkout.Models;

namespace Checkout.Interfaces
{
    public interface IRepository
    {
        decimal FindPrice(string code);

        Sku FindSku(string code);

        IList<MultibuyDiscount> MultibuyDiscounts { get; }
    }
}