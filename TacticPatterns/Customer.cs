using System;
using TacticPatterns.Factories;

namespace TacticPatterns
{
    public class Customer
    {
        public int Id { get; }
        
        public string FullName { get; set; }
        public string PhoneNum { get; set; }
        public string EMail { get; set; }

        public CardType Card;
        public PaymentType Payment;
        
        public AccountType Account;

        public Customer(int id, string fullName, AccountType account, string phoneNum, string eMail, CardType card, PaymentType payment)
        {
            this.Id = id;
            this.FullName = fullName;
            this.PhoneNum = phoneNum;
            this.EMail = eMail;
            this.Card = card;
            this.Payment = payment;
            this.Account = account;
        }

        public Order MakeOrder(IOrderFactory factory, IRepository<Order> rep)
        {
            Order newOrder = factory.CreateOrder(this.Id);
            rep.Add(newOrder);
            Console.WriteLine(this.FullName+" made an order #"+newOrder.Id+". The order includes:");
            double totalCost = 0;
            foreach (var product in newOrder.Products)
            {
                Console.WriteLine("* "+product.Name+" ("+product.Price+" руб.)");
                totalCost += product.Price;
            }
            Console.WriteLine("The total cost is: "+totalCost+" руб.");
            return newOrder;
        }
    }
}