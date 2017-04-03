namespace Checkout.Models
{
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