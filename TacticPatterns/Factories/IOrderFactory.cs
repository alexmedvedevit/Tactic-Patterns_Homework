namespace TacticPatterns.Factories
{
    public interface IOrderFactory
    {
        Order CreateOrder(int customerId);
    }
}