namespace TacticPatterns.Factories
{
    public class ChildCustomerFactory:ICustomerFactory
    {
        public Customer CreateCustomer()
        {
            return new Customer(2, "Little Timmy",AccountType.ChildAccount,"Doesn't have one :(","Email",CardType.Mir,PaymentType.DuringTheOrdering);
        }
    }
}