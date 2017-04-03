namespace Checkout
{
    public interface IRepository
    {
        decimal FindPrice(string code);
    }
}