namespace TacticPatterns.Factories
{
    public class AdultCustomerFactory:ICustomerFactory
    {
        public Customer CreateCustomer()
        {
            return new Customer(1,"Mr. William Peterson",AccountType.CommonAccount,"+7 (XXX) XXX-XX-XX","Email",CardType.Visa,PaymentType.AfterReceiving);
        }
    }
}