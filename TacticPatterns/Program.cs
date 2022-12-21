using System;
using TacticPatterns.Factories;

namespace TacticPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<Customer> customerRepository = new CustomerRepository();
            IRepository<Order> orderRepository = new OrderRepository();

            ICustomerFactory adultCustomerFactory = new AdultCustomerFactory();
            ICustomerFactory childCustomerFactory = new ChildCustomerFactory();

            IOrderFactory childOrderFactory = new ChildOrderFactory();
            IOrderFactory commonOrderFactory = new CommonOrderFactory();


            customerRepository.Add(adultCustomerFactory.CreateCustomer());
            customerRepository.Add(childCustomerFactory.CreateCustomer());

            foreach (var customer in customerRepository.GetAll())
            {
                if(customer.Account == AccountType.ChildAccount)
                    customer.MakeOrder(childOrderFactory,orderRepository);
                else customer.MakeOrder(commonOrderFactory,orderRepository);
            }
        }
    }
}