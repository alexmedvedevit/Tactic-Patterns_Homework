using System;
using System.Collections.Generic;

namespace TacticPatterns.Factories
{
    public class ChildOrderFactory:IOrderFactory
    {
        public Order CreateOrder(int customerId)
        {
            return new Order(2, "Pushkina St.", DateTime.Today, customerId, new List<Product>(){new Product(550.00,"Teddybear Plushie"),new Product(85.00,"Color Pencils")});
        }
    }
}