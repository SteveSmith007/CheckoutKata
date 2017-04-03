namespace Checkout.Models
{
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
}