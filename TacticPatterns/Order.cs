using System;
using System.Collections.Generic;

namespace TacticPatterns
{
    public class Order
    {
        public int Id { get; }
        public string Address { get; set; }
        public DateTime DateOfOrdering { get; set; }
        
        public int CustomerId;
        
        public List<Product> Products;
        
        public OrderStatus Status;

        public Order(int id, string address, DateTime dateOfOrdering, int customerId, List<Product> products)
        {
            this.Id = id;
            this.Address = address;
            this.DateOfOrdering = dateOfOrdering;
            this.CustomerId = customerId;
            this.Products = products;
        }
    }
}