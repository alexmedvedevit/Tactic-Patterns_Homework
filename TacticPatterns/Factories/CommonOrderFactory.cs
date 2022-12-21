using System;
using System.Collections.Generic;

namespace TacticPatterns.Factories
{
    public class CommonOrderFactory:IOrderFactory
    {
        public Order CreateOrder(int customerId)
        {
            return new Order(1, "Lenina Av.", DateTime.Today, customerId, new List<Product>(){new Product(55.00,"Baltika-9")});
        }
    }
}