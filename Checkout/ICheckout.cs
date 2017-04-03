namespace CheckoutKata
{
    public interface ICheckout
    {
        decimal Total { get; }
        void Register(string code, int qty = 1);
    }
}